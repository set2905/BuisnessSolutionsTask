import { makeObservable, observable } from "mobx";
import { Client } from "../clients";

class ClientStore {
    client: Client;
    constructor(client: Client) {
        makeObservable(this, {
            client: observable,
        })
        this.client = client
    }
}

export function createClientStore() {
    const endpoint = process.env.REACT_APP_SERVICE_URI ? process.env.REACT_APP_SERVICE_URI : "https://localhost:7201";
    return new ClientStore(new Client());
}
