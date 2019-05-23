import { IConnector } from "./iconnector";
import { Promise, PromiseFactory } from "../models/promise";
import { Http } from "@angular/http";

export class JSONConnector implements IConnector{
    public get(url:string):Promise{
        let http: Http= window.ioc.resolve(Http);
        let promise: Promise = PromiseFactory.create();
        http.get(url)
            .map(response => response.json())
            .subscribe((data: any)=>{
                promise.resolve(data);
            },(errors: any)=>{
                promise.reject(errors);
            });
        return promise;
    }

    public post(url:string, data: any):Promise{
        let http: Http= window.ioc.resolve(Http);
        let promise: Promise = PromiseFactory.create();
        http.post(url, data)
            .map(response => response.json())
            .subscribe((data: any)=>{
                promise.resolve(data);
            },(errors: any)=>{
                promise.reject(errors);
            });
        return promise;
    }
}