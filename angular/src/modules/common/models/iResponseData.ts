import { HttpStatusCode } from "./enum";

export interface IResponseData{
    data:any,
    status:HttpStatusCode,
    errors:Array<string>
}