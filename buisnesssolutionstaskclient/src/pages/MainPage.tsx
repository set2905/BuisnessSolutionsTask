import { DatePicker, Table, Space, Button } from 'antd';
import React, { useState } from 'react';
import { Client, OrderDto, OrderFilter } from "./clients";
import dayjs from 'dayjs';

const { RangePicker } = DatePicker;

function _MainPage() {
    const dateFormat = 'YYYY-MM-DD';
    interface TableFilters {
        dateStart: string,
        dateEnd: string,
        page: number,
        orderFilter?: OrderFilter
    }

    const [orders, setOrders] = useState<OrderDto[] | undefined>();
    const [loading, setLoading] = useState(false);
    const [filter, setFilter] = useState<TableFilters>({
        dateStart: getCurrentDate(-1),
        dateEnd: getCurrentDate(0),
        page: 1,
    });

    function getCurrentDate(offset: number): string {
        const today = new Date();
        const month = today.getMonth() + 1 + offset;
        const year = today.getFullYear();
        const date = today.getDate();
        return year + "-" + month + "-" + date;
    }

    async function loadOrders() {
        const client = new Client("https://localhost:7201");
        setLoading(true);
        const result = await client.findPOST(filter.dateStart, filter.dateEnd, 1, undefined);
        setOrders(result as OrderDto[]);
        setLoading(false);
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
            <Button loading={loading} onClick={() => { loadOrders() }}>Apply filters</Button>
            <RangePicker
                defaultValue={[dayjs(getCurrentDate(-1), dateFormat), dayjs(getCurrentDate(0), dateFormat)]}
                onChange={(dates, dateStrings) => setFilter({
                dateStart: dateStrings[0],
                dateEnd: dateStrings[1],
                page: filter.page,
                orderFilter: filter.orderFilter
                })} />

            <Table dataSource={orders} columns={columns} loading={loading} />
        </Space>
    );
}

const MainPage = React.memo(_MainPage);
export default MainPage;