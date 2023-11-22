import { useNavigate } from 'react-router-dom';
import { useStores } from '../hooks/useStores';
import { Button, Card, List } from 'antd';

function ViewOrderPage() {
    const { currentOrderStore } = useStores();
    const navigate = useNavigate();

    return (
        <Card title="Order View" bordered={false} style={{ width: 600 }}
            actions={
                [
                    <Button onClick={()=>navigate('/edit')}>Edit</Button>,
                    <Button>Delete</Button>
                ]}
        >
            <h3>Order Number:</h3>
            <p>{currentOrderStore.order.number}</p>
            <h3>Order date:</h3>
            <p>{currentOrderStore.order.date}</p>
            <h3>Order provider:</h3>
            <p>{currentOrderStore.order.provider?.name}</p>
            <List
                header={<div>Order items</div>}
                bordered
                dataSource={currentOrderStore.order.items}
                renderItem={(item) => (
                    <List.Item>
                        <p>{item.name}</p>
                        <p>{item.quantity}</p>
                        <p>{item.unit}</p>
                    </List.Item>
                )}
            />
        </Card>
    );
}

export default ViewOrderPage;