import { Input, DatePicker, Button, message, Space } from 'antd';
import { ApiException, Client, OrderDto, ProviderDto } from '../clients'
import cloneDeep from 'lodash.clonedeep';
import Select, { DefaultOptionType, SelectProps } from 'antd/es/select';
import { useState } from 'react';

const client = new Client("https://localhost:7201");

function OrderForm(existingOrder?: OrderDto) {
    const [order, setOrder] = useState<OrderDto>({ number: "", date: "", providerId: { value: 0 }, items: [] });
    const [providerSelectProps, setProviderSelectProps] = useState<DefaultOptionType[]>([]);
    const [selectedProviderOption, setSelectedProviderOption] = useState<DefaultOptionType>();
    const [messageApi, contextHolder] = message.useMessage();
    async function fetchDistinctProviders(search: string) {
        const result = (await client.findGET(search).catch(e => {
            if (e instanceof ApiException) messageApi.open({
                type: 'error',
                content: (e as ApiException).response,
            });
        })) as ProviderDto[];
        const opts = result.map<DefaultOptionType>((x) => { return { label: x.name, value: x.id?.value } });
        setProviderSelectProps(opts);
    }

    const handleChange = (newValue: DefaultOptionType) => {
        setSelectedProviderOption(newValue);
        const copy = cloneDeep(order) as OrderDto;
        copy.providerId = { value: selectedProviderOption?.value as number }
        setOrder(copy);
    };

    async function onSubmit() {
        if (order == undefined) return;
        if (order.id == undefined)
            await client.create(order).catch(e => {
                if (e instanceof ApiException) messageApi.open({
                    type: 'error',
                    content: (e as ApiException).response,
                });
            });
        else
            await client.update(order).catch(e => {
                if (e instanceof ApiException) messageApi.open({
                    type: 'error',
                    content: (e as ApiException).response,
                });
            });
    };

    const onNumberChange = (e: React.ChangeEvent<HTMLInputElement | HTMLTextAreaElement>) => {
        const copy = cloneDeep(order) as OrderDto;
        copy.number = e.target.value;
        setOrder(copy);
    };
    return (
        <Space direction="vertical" size="middle">
            {contextHolder}
            <Input placeholder="Please enter order number"
                onChange={onNumberChange} />
            <Select
                showSearch
                value={selectedProviderOption}
                placeholder="Select provider"
                onSearch={fetchDistinctProviders}
                onChange={handleChange}
                options={providerSelectProps }
            />
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