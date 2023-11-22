import { makeObservable, observable, action } from "mobx";
import { OrderDto } from "../clients";

class CurrentOrderStore {
    order: OrderDto = { id: undefined, number: "", date: "", providerId: undefined, items: [] };
    constructor(order: OrderDto) {
        makeObservable(this, {
            order: observable,
            setOrder: action,
            clearOrder: action,
        })
        this.order = order
    }

    setOrder(order: OrderDto) {
        this.order = order;
    }
    clearOrder() {
        this.order = { id: undefined, number: "", date: "", providerId: undefined, items: [] };
    }
}

export function createCurrentOrderStore() {
    return new CurrentOrderStore({ id: undefined, number: "", date: "", providerId: undefined, items: [] });
}
