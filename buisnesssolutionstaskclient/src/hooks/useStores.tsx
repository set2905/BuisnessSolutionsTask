import { useContext } from "react";
import { storesContext } from "../contexts/stores-contexts";

export const useStores = () => useContext(storesContext);
