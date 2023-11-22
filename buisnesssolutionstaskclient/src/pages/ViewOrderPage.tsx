import React from 'react';
import { useStores } from '../hooks/useStores';
import { Card } from 'antd';

function ViewOrderPage() {
    const { currentOrderStore } = useStores();

    return (
        <Card title="Order" bordered={false} style={{ width: 600 }}>
            <p>{currentOrderStore.order.number}</p>
            <p>{currentOrderStore.order.date}</p>
        </Card>
    );
}

export default ViewOrderPage;