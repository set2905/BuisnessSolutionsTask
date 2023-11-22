import { Input, DatePicker, Button, message, Space, List, InputNumber } from 'antd';
import { ApiException, OrderDto, ProviderDto } from '../clients'
import cloneDeep from 'lodash.clonedeep';
import Select, { DefaultOptionType } from 'antd/es/select';
import { useState } from 'react';
import { useStores } from '../hooks/useStores';
import dayjs from 'dayjs';

function OrderForm() {
    const { currentOrderStore, clientStore } = useStores();
    const [order, setOrder] = useState<OrderDto>(currentOrderStore.order);
    const [providerSelectProps, setProviderSelectProps] = useState<DefaultOptionType[]>([]);
    const [messageApi, contextHolder] = message.useMessage();

    const dateFormat = 'YYYY-MM-DD';

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
            <DatePicker
                defaultValue={dayjs(order.date, dateFormat)}
                onChange={(_, dateString) => {
                    const copy = cloneDeep(order) as OrderDto;
                    copy.date = dateString;
                    setOrder(copy);
                }} />
            <List
                header={<div>Order items</div>}
                bordered
                dataSource={order.items}
                renderItem={(item) => (
                    <List.Item>
                        <Space direction="vertical">
                            <h2>Item</h2>
                            <Space>
                                <p>Item name</p>
                                <Input defaultValue={item.name} onChange={(val) => { item.name = val.target.value }}>
                                </Input>
                                <p>Quantity</p>
                                <InputNumber defaultValue={item.quantity} onChange={(val) => { item.quantity = val ?? undefined }}>
                                </InputNumber>
                                <p>Unit</p>
                                <Input defaultValue={item.unit} onChange={(val) => { item.unit = val.target.value }}>
                                </Input>
                                <Button onClick={() => {
                                    const copy = cloneDeep(order) as OrderDto;
                                    copy.items = copy.items?.filter(function (e) { return e.id?.value !== item.id?.value })
                                    setOrder(copy);
                                }}>
                                    Remove this item
                                </Button>
                            </Space>
                        </Space>
                    </List.Item>
                )}
            />
            <Button onClick={() => {
                const copy = cloneDeep(order) as OrderDto;
                copy.items?.push({});
                setOrder(copy);
            }}>
                Add new item
            </Button>
            <Button onClick={onSubmit} type="primary">
                Submit
            </Button>
        </Space >
    );
}

export default OrderForm;