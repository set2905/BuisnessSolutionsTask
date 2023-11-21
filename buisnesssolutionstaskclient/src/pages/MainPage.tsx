import { DatePicker, Space } from 'antd';
import React, { useState } from 'react';
import { OrderFilter } from "./clients";

const { RangePicker } = DatePicker;


const _MainPage = () => {
    const [filter, setFilter] = useState(OrderFilter);
    return (
        <Space>
            <RangePicker />
        </Space>
    );
}

const MainPage = React.memo(_MainPage);
export default MainPage;