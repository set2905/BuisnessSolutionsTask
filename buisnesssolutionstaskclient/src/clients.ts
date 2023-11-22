//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.19.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

/* tslint:disable */
/* eslint-disable */
// ReSharper disable InconsistentNaming

export class Client {
    private http: { fetch(url: RequestInfo, init?: RequestInit): Promise<Response> };
    private baseUrl: string;
    protected jsonParseReviver: ((key: string, value: any) => any) | undefined = undefined;

    constructor(baseUrl?: string, http?: { fetch(url: RequestInfo, init?: RequestInit): Promise<Response> }) {
        this.http = http ? http : window as any;
        this.baseUrl = baseUrl !== undefined && baseUrl !== null ? baseUrl : "";
    }

    /**
     * @param search (optional) 
     * @return Success
     */
    findOrderNumbers(search: string | undefined): Promise<StringListResult> {
        let url_ = this.baseUrl + "/findOrderNumbers?";
        if (search === null)
            throw new Error("The parameter 'search' cannot be null.");
        else if (search !== undefined)
            url_ += "search=" + encodeURIComponent("" + search) + "&";
        url_ = url_.replace(/[?&]$/, "");

        let options_: RequestInit = {
            method: "GET",
            headers: {
                "Accept": "text/plain"
            }
        };

        return this.http.fetch(url_, options_).then((_response: Response) => {
            return this.processFindOrderNumbers(_response);
        });
    }

    protected processFindOrderNumbers(response: Response): Promise<StringListResult> {
        const status = response.status;
        let _headers: any = {}; if (response.headers && response.headers.forEach) { response.headers.forEach((v: any, k: any) => _headers[k] = v); };
        if (status === 200) {
            return response.text().then((_responseText) => {
            let result200: any = null;
            result200 = _responseText === "" ? null : JSON.parse(_responseText, this.jsonParseReviver) as StringListResult;
            return result200;
            });
        } else if (status !== 200 && status !== 204) {
            return response.text().then((_responseText) => {
            return throwException("An unexpected server error occurred.", status, _responseText, _headers);
            });
        }
        return Promise.resolve<StringListResult>(null as any);
    }

    /**
     * @param search (optional) 
     * @return Success
     */
    findOrderItemNames(search: string | undefined): Promise<StringListResult> {
        let url_ = this.baseUrl + "/findOrderItemNames?";
        if (search === null)
            throw new Error("The parameter 'search' cannot be null.");
        else if (search !== undefined)
            url_ += "search=" + encodeURIComponent("" + search) + "&";
        url_ = url_.replace(/[?&]$/, "");

        let options_: RequestInit = {
            method: "GET",
            headers: {
                "Accept": "text/plain"
            }
        };

        return this.http.fetch(url_, options_).then((_response: Response) => {
            return this.processFindOrderItemNames(_response);
        });
    }

    protected processFindOrderItemNames(response: Response): Promise<StringListResult> {
        const status = response.status;
        let _headers: any = {}; if (response.headers && response.headers.forEach) { response.headers.forEach((v: any, k: any) => _headers[k] = v); };
        if (status === 200) {
            return response.text().then((_responseText) => {
            let result200: any = null;
            result200 = _responseText === "" ? null : JSON.parse(_responseText, this.jsonParseReviver) as StringListResult;
            return result200;
            });
        } else if (status !== 200 && status !== 204) {
            return response.text().then((_responseText) => {
            return throwException("An unexpected server error occurred.", status, _responseText, _headers);
            });
        }
        return Promise.resolve<StringListResult>(null as any);
    }

    /**
     * @param search (optional) 
     * @return Success
     */
    findOrderItemUnits(search: string | undefined): Promise<StringListResult> {
        let url_ = this.baseUrl + "/findOrderItemUnits?";
        if (search === null)
            throw new Error("The parameter 'search' cannot be null.");
        else if (search !== undefined)
            url_ += "search=" + encodeURIComponent("" + search) + "&";
        url_ = url_.replace(/[?&]$/, "");

        let options_: RequestInit = {
            method: "GET",
            headers: {
                "Accept": "text/plain"
            }
        };

        return this.http.fetch(url_, options_).then((_response: Response) => {
            return this.processFindOrderItemUnits(_response);
        });
    }

    protected processFindOrderItemUnits(response: Response): Promise<StringListResult> {
        const status = response.status;
        let _headers: any = {}; if (response.headers && response.headers.forEach) { response.headers.forEach((v: any, k: any) => _headers[k] = v); };
        if (status === 200) {
            return response.text().then((_responseText) => {
            let result200: any = null;
            result200 = _responseText === "" ? null : JSON.parse(_responseText, this.jsonParseReviver) as StringListResult;
            return result200;
            });
        } else if (status !== 200 && status !== 204) {
            return response.text().then((_responseText) => {
            return throwException("An unexpected server error occurred.", status, _responseText, _headers);
            });
        }
        return Promise.resolve<StringListResult>(null as any);
    }

    /**
     * @param startDate (optional) 
     * @param endDate (optional) 
     * @param page (optional) 
     * @param body (optional) 
     * @return Success
     */
    findPOST(startDate: string | undefined, endDate: string | undefined, page: number | undefined, body: OrderFilter | undefined): Promise<OrderDtoArrayResult> {
        let url_ = this.baseUrl + "/api/orders/find?";
        if (startDate === null)
            throw new Error("The parameter 'startDate' cannot be null.");
        else if (startDate !== undefined)
            url_ += "startDate=" + encodeURIComponent("" + startDate) + "&";
        if (endDate === null)
            throw new Error("The parameter 'endDate' cannot be null.");
        else if (endDate !== undefined)
            url_ += "endDate=" + encodeURIComponent("" + endDate) + "&";
        if (page === null)
            throw new Error("The parameter 'page' cannot be null.");
        else if (page !== undefined)
            url_ += "page=" + encodeURIComponent("" + page) + "&";
        url_ = url_.replace(/[?&]$/, "");

        const content_ = JSON.stringify(body);

        let options_: RequestInit = {
            body: content_,
            method: "POST",
            headers: {
                "Content-Type": "application/json",
                "Accept": "text/plain"
            }
        };

        return this.http.fetch(url_, options_).then((_response: Response) => {
            return this.processFindPOST(_response);
        });
    }

    protected processFindPOST(response: Response): Promise<OrderDtoArrayResult> {
        const status = response.status;
        let _headers: any = {}; if (response.headers && response.headers.forEach) { response.headers.forEach((v: any, k: any) => _headers[k] = v); };
        if (status === 200) {
            return response.text().then((_responseText) => {
            let result200: any = null;
            result200 = _responseText === "" ? null : JSON.parse(_responseText, this.jsonParseReviver) as OrderDtoArrayResult;
            return result200;
            });
        } else if (status !== 200 && status !== 204) {
            return response.text().then((_responseText) => {
            return throwException("An unexpected server error occurred.", status, _responseText, _headers);
            });
        }
        return Promise.resolve<OrderDtoArrayResult>(null as any);
    }

    /**
     * @param body (optional) 
     * @return Success
     */
    create(body: OrderDto | undefined): Promise<Result> {
        let url_ = this.baseUrl + "/api/orders/create";
        url_ = url_.replace(/[?&]$/, "");

        const content_ = JSON.stringify(body);

        let options_: RequestInit = {
            body: content_,
            method: "POST",
            headers: {
                "Content-Type": "application/json",
                "Accept": "text/plain"
            }
        };

        return this.http.fetch(url_, options_).then((_response: Response) => {
            return this.processCreate(_response);
        });
    }

    protected processCreate(response: Response): Promise<Result> {
        const status = response.status;
        let _headers: any = {}; if (response.headers && response.headers.forEach) { response.headers.forEach((v: any, k: any) => _headers[k] = v); };
        if (status === 200) {
            return response.text().then((_responseText) => {
            let result200: any = null;
            result200 = _responseText === "" ? null : JSON.parse(_responseText, this.jsonParseReviver) as Result;
            return result200;
            });
        } else if (status !== 200 && status !== 204) {
            return response.text().then((_responseText) => {
            return throwException("An unexpected server error occurred.", status, _responseText, _headers);
            });
        }
        return Promise.resolve<Result>(null as any);
    }

    /**
     * @param body (optional) 
     * @return Success
     */
    update(body: OrderDto | undefined): Promise<Result> {
        let url_ = this.baseUrl + "/api/orders/update";
        url_ = url_.replace(/[?&]$/, "");

        const content_ = JSON.stringify(body);

        let options_: RequestInit = {
            body: content_,
            method: "POST",
            headers: {
                "Content-Type": "application/json",
                "Accept": "text/plain"
            }
        };

        return this.http.fetch(url_, options_).then((_response: Response) => {
            return this.processUpdate(_response);
        });
    }

    protected processUpdate(response: Response): Promise<Result> {
        const status = response.status;
        let _headers: any = {}; if (response.headers && response.headers.forEach) { response.headers.forEach((v: any, k: any) => _headers[k] = v); };
        if (status === 200) {
            return response.text().then((_responseText) => {
            let result200: any = null;
            result200 = _responseText === "" ? null : JSON.parse(_responseText, this.jsonParseReviver) as Result;
            return result200;
            });
        } else if (status !== 200 && status !== 204) {
            return response.text().then((_responseText) => {
            return throwException("An unexpected server error occurred.", status, _responseText, _headers);
            });
        }
        return Promise.resolve<Result>(null as any);
    }

    /**
     * @param search (optional) 
     * @return Success
     */
    findGET(search: string | undefined): Promise<ProviderDtoArrayResult> {
        let url_ = this.baseUrl + "/api/providers/find?";
        if (search === null)
            throw new Error("The parameter 'search' cannot be null.");
        else if (search !== undefined)
            url_ += "search=" + encodeURIComponent("" + search) + "&";
        url_ = url_.replace(/[?&]$/, "");

        let options_: RequestInit = {
            method: "GET",
            headers: {
                "Accept": "text/plain"
            }
        };

        return this.http.fetch(url_, options_).then((_response: Response) => {
            return this.processFindGET(_response);
        });
    }

    protected processFindGET(response: Response): Promise<ProviderDtoArrayResult> {
        const status = response.status;
        let _headers: any = {}; if (response.headers && response.headers.forEach) { response.headers.forEach((v: any, k: any) => _headers[k] = v); };
        if (status === 200) {
            return response.text().then((_responseText) => {
            let result200: any = null;
            result200 = _responseText === "" ? null : JSON.parse(_responseText, this.jsonParseReviver) as ProviderDtoArrayResult;
            return result200;
            });
        } else if (status !== 200 && status !== 204) {
            return response.text().then((_responseText) => {
            return throwException("An unexpected server error occurred.", status, _responseText, _headers);
            });
        }
        return Promise.resolve<ProviderDtoArrayResult>(null as any);
    }
}

export interface OrderDto {
    id?: OrderId;
    number?: string | undefined;
    date?: string;
    provider?: ProviderDto;
    items?: OrderItemDto[] | undefined;
}

export interface OrderDtoArrayResult {
    value?: OrderDto[] | undefined;
    status?: ResultStatus;
    readonly isSuccess?: boolean;
    readonly successMessage?: string | undefined;
    readonly correlationId?: string | undefined;
    readonly errors?: string[] | undefined;
    readonly validationErrors?: ValidationError[] | undefined;
}

export interface OrderFilter {
    numberFilter?: string[] | undefined;
    providerFilter?: ProviderId[] | undefined;
    orderItemNameFilter?: string[] | undefined;
    orderItemUnitFilter?: string[] | undefined;
}

export interface OrderId {
    value?: number;
}

export interface OrderItemDto {
    id?: OrderItemId;
    name?: string | undefined;
    quantity?: number;
    unit?: string | undefined;
}

export interface OrderItemId {
    value?: number;
}

export interface ProviderDto {
    id?: ProviderId;
    name?: string | undefined;
}

export interface ProviderDtoArrayResult {
    value?: ProviderDto[] | undefined;
    status?: ResultStatus;
    readonly isSuccess?: boolean;
    readonly successMessage?: string | undefined;
    readonly correlationId?: string | undefined;
    readonly errors?: string[] | undefined;
    readonly validationErrors?: ValidationError[] | undefined;
}

export interface ProviderId {
    value?: number;
}

export interface Result {
    value?: Result;
    status?: ResultStatus;
    readonly isSuccess?: boolean;
    readonly successMessage?: string | undefined;
    readonly correlationId?: string | undefined;
    readonly errors?: string[] | undefined;
    readonly validationErrors?: ValidationError[] | undefined;
}

export enum ResultStatus {
    _0 = 0,
    _1 = 1,
    _2 = 2,
    _3 = 3,
    _4 = 4,
    _5 = 5,
    _6 = 6,
    _7 = 7,
    _8 = 8,
}

export interface StringListResult {
    value?: string[] | undefined;
    status?: ResultStatus;
    readonly isSuccess?: boolean;
    readonly successMessage?: string | undefined;
    readonly correlationId?: string | undefined;
    readonly errors?: string[] | undefined;
    readonly validationErrors?: ValidationError[] | undefined;
}

export interface ValidationError {
    identifier?: string | undefined;
    errorMessage?: string | undefined;
    errorCode?: string | undefined;
    severity?: ValidationSeverity;
}

export enum ValidationSeverity {
    _0 = 0,
    _1 = 1,
    _2 = 2,
}

export class ApiException extends Error {
    message: string;
    status: number;
    response: string;
    headers: { [key: string]: any; };
    result: any;

    constructor(message: string, status: number, response: string, headers: { [key: string]: any; }, result: any) {
        super();

        this.message = message;
        this.status = status;
        this.response = response;
        this.headers = headers;
        this.result = result;
    }

    protected isApiException = true;

    static isApiException(obj: any): obj is ApiException {
        return obj.isApiException === true;
    }
}

function throwException(message: string, status: number, response: string, headers: { [key: string]: any; }, result?: any): any {
    if (result !== null && result !== undefined)
        throw result;
    else
        throw new ApiException(message, status, response, headers, null);
}