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
    return new ClientStore(new Client("https://localhost:7201"));
}
