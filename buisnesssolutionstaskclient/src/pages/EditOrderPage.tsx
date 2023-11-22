import OrderForm from '../components/OrderForm';




function EditOrderPage() {
    const { currentOrderStore, clientStore } = useStores();

    return (
        <OrderForm />
    );
}

export default EditOrderPage;