import { createContext } from "react";
import { createCurrentOrderStore } from "../stores/currentorder-store";

export const storesContext = createContext({
    currentOrderStore: createCurrentOrderStore()
});
