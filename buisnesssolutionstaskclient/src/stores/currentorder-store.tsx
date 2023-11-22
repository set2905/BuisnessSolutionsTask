import { makeObservable, observable, action } from "mobx";
import { OrderDto } from "../clients";
import dayjs from 'dayjs';

class CurrentOrderStore {
    order: OrderDto = { id: undefined, number: "", date: dayjs().toString(), provider: undefined, items: [] };

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
        this.order = { id: undefined, number: "", date: "", provider: undefined, items: [] };
    }
}

export function createCurrentOrderStore() {
    return new CurrentOrderStore({ id: undefined, number: "", date: dayjs().toString(), provider: undefined, items: [] });
}
