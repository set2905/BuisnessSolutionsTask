import { createContext } from "react";
import { createCurrentOrderStore } from "../stores/currentorder-store";
import { createClientStore } from "../stores/client-store";

export const storesContext = createContext({
    currentOrderStore: createCurrentOrderStore(),
    clientStore: createClientStore(),
});
