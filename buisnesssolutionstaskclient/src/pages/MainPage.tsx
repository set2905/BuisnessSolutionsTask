import { DatePicker, Table, Space, Button } from 'antd';
import React, { useState } from 'react';
import { Client, OrderDto, OrderFilter, ProviderDto, ProviderId } from "../clients";
import dayjs from 'dayjs';
import DebounceSelect from '../components/DebounceSelect'
import cloneDeep from 'lodash.clonedeep';
import { DefaultOptionType } from 'antd/es/select';
import OrderForm from '../components/OrderForm';

const { RangePicker } = DatePicker;

function _MainPage() {
    const dateFormat = 'YYYY-MM-DD';
    const client = new Client("https://localhost:7201");

    interface TableFilters {
        dateStart: string,
        dateEnd: string,
        page: number,
        orderFilter: OrderFilter
    }


    const [orders, setOrders] = useState<OrderDto[] | undefined>();
    const [loading, setLoading] = useState(false);
    const [filter, setFilter] = useState<TableFilters>({
        dateStart: getCurrentDate(-1),
        dateEnd: getCurrentDate(0),
        page: 1,
        orderFilter: {
            orderItemNameFilter: undefined,
            orderItemUnitFilter: undefined,
            numberFilter: undefined,
            providerFilter: undefined
        }
    });

    function getCurrentDate(offset: number): string {
        const today = new Date();
        const month = today.getMonth() + 1 + offset;
        const year = today.getFullYear();
        const date = today.getDate();
        return year + "-" + month + "-" + date;
    }

    async function loadOrders() {
        setLoading(true);
        const result = await client.findPOST(filter.dateStart, filter.dateEnd, 1, filter.orderFilter);
        setOrders(result as OrderDto[]);
        setLoading(false);
    }

    async function fetchDistinctOrderNumbers(search: string): Promise<DefaultOptionType[]> {
        const result = (await client.findOrderNumbers(search)) as string[];
        return result.map((x) => { return { label: x, value: x } });
    }

    async function fetchDistinctOrderItemUnits(search: string): Promise<DefaultOptionType[]> {
        const result = (await client.findOrderItemUnits(search)) as string[];
        return result.map((x) => { return { label: x, value: x } });
    }

    async function fetchDistinctOrderItemNames(search: string): Promise<DefaultOptionType[]> {
        const result = (await client.findOrderItemNames(search)) as string[];
        return result.map((x) => { return { label: x, value: x } });
    }

    async function fetchDistinctProviders(search: string): Promise<DefaultOptionType[]> {
        const result = (await client.findGET(search)) as ProviderDto[];
        return result.map((x) => { return { label: x.name, value: x.id?.value } });
    }

    React.useEffect(() => {
        loadOrders();
    }, []);

    const columns = [
        {
            title: 'Number',
            dataIndex: 'number',
            key: 'number',
        },
        {
            title: 'Date',
            dataIndex: 'date',
            key: 'date',
        },
    ];
    return (
        <Space direction="vertical" size="middle" style={{ display: 'flex' }}>
            <OrderForm/>
            <RangePicker
                defaultValue={[dayjs(getCurrentDate(-1), dateFormat), dayjs(getCurrentDate(0), dateFormat)]}
                onChange={(_, dateStrings) => {
                    const copy = cloneDeep(filter) as TableFilters;
                    copy.dateStart = dateStrings[0];
                    copy.dateEnd = dateStrings[1];
                    setFilter(copy)
                }} />
            <DebounceSelect
                mode="multiple"
                placeholder="Select order numbers"
                fetchOptions={fetchDistinctOrderNumbers}
                onChange={(value) => {
                    const copy = cloneDeep(filter) as TableFilters;
                    const selected = value as DefaultOptionType[];
                    copy.orderFilter.numberFilter = selected.map((x) => x.value as string);
                    setFilter(copy);
                }}
                style={{ width: '100%' }}
            />
            <DebounceSelect
                mode="multiple"
                placeholder="Select order item units"
                fetchOptions={fetchDistinctOrderItemUnits}
                onChange={(value) => {
                    const copy = cloneDeep(filter) as TableFilters;
                    const selected = value as DefaultOptionType[];
                    copy.orderFilter.orderItemUnitFilter = selected.map((x) => x.value as string);
                    setFilter(copy);
                }}
                style={{ width: '100%' }}
            />
            <DebounceSelect
                mode="multiple"
                placeholder="Select order item names"
                fetchOptions={fetchDistinctOrderItemNames}
                onChange={(value) => {
                    const copy = cloneDeep(filter) as TableFilters;
                    const selected = value as DefaultOptionType[];
                    copy.orderFilter.orderItemNameFilter = selected.map((x) => x.value as string);
                    setFilter(copy);
                }}
                style={{ width: '100%' }}
            />
            <DebounceSelect
                mode="multiple"
                placeholder="Select order providers"
                fetchOptions={fetchDistinctProviders}
                onChange={(value) => {
                    const copy = cloneDeep(filter) as TableFilters;
                    const selected = value as DefaultOptionType[];
                    copy.orderFilter.providerFilter = selected.map<ProviderId>((x) => { return { value: x.value as number } });
                    setFilter(copy);
                }}
                style={{ width: '100%' }}
            />
            <Button loading={loading} onClick={() => { loadOrders() }}>Apply filters</Button>
            <Button loading={loading} onClick={() => { loadOrders() }}>Add new order</Button>

            <Table dataSource={orders} columns={columns} loading={loading} />
        </Space>
    );
}

const MainPage = React.memo(_MainPage);
export default MainPage;