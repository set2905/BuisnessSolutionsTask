import { Input, DatePicker, Button, message, Space } from 'antd';
import { ApiException, OrderDto, ProviderDto } from '../clients'
import cloneDeep from 'lodash.clonedeep';
import Select, { DefaultOptionType } from 'antd/es/select';
import { useState } from 'react';
import { useStores } from '../hooks/useStores';


function OrderForm() {
    const { currentOrderStore, clientStore } = useStores();
    const [order, setOrder] = useState<OrderDto>(currentOrderStore.order);
    const [providerSelectProps, setProviderSelectProps] = useState<DefaultOptionType[]>([]);
    const [messageApi, contextHolder] = message.useMessage();

    async function fetchDistinctProviders(search: string) {
        const result = (await clientStore.client.findGET(search).catch(e => {
            if (e instanceof ApiException) messageApi.open({
                type: 'error',
                content: (e as ApiException).response,
            });
        })) as ProviderDto[];
        const opts = result.map<DefaultOptionType>((x) => { return { label: x.name, value: x.id?.value } });
        setProviderSelectProps(opts);
    }

    const handleChange = (value: { value: number; label: React.ReactNode }) => {
        const copy = cloneDeep(order) as OrderDto;
        copy.provider = {
            id: { value: value.value },
            name: value.label as string
        };
        setOrder(copy);
    };

    async function onSubmit() {
        if (order == undefined) return;
        let exception = false;
        if (order.id == undefined)
            await clientStore.client.create(order).catch(e => {
                exception = true;
                if (e instanceof ApiException) messageApi.open({
                    type: 'error',
                    content: (e as ApiException).response,
                });
            });
        else
            await clientStore.client.update(order).catch(e => {
                exception = true;
                if (e instanceof ApiException) messageApi.open({
                    type: 'error',
                    content: (e as ApiException).response,
                });
            });
        if (!exception)
            messageApi.open({
                type: 'success',
                content: "Success",
            });
    };

    const onNumberChange = (e: React.ChangeEvent<HTMLInputElement | HTMLTextAreaElement>) => {
        const copy = cloneDeep(order) as OrderDto;
        copy.number = e.target.value;
        setOrder(copy);
    };

    function initOrderNumber(): number {
        if (order.provider != undefined && order.provider.id != undefined && order.provider.id.value != undefined)
            return order.provider.id.value;
        else
            return 0;
    }

    return (
        <Space direction="vertical" size="middle">
            {contextHolder}
            <Input placeholder="Please enter client number"
                defaultValue={order.number}
                onChange={onNumberChange} />
            <Select
                showSearch
                labelInValue
                defaultValue={{ value: initOrderNumber(), label: order.provider?.name }}
                placeholder="Select provider"
                onSearch={fetchDistinctProviders}
                onChange={handleChange}
                options={providerSelectProps} />
            <DatePicker onChange={(_, dateString) => {
                const copy = cloneDeep(order) as OrderDto;
                copy.date = dateString;
                setOrder(copy);
            }} />
            <Button onClick={onSubmit} type="primary">
                Submit
            </Button>
        </Space>
    );
}

export default OrderForm;