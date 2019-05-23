///<preference path="./extension.d.ts" /> 
import { platformBrowserDynamic } from "@angular/platform-browser-dynamic";
import { UserModule } from "./modules/userManagement/userModule";
import {IoCFactory}  from "./modules/common/ioc/iocFactory";
import registrations from "./modules/userManagement/_shared/config/ioc";
let iocContainer: IIoCContainer = IoCFactory.create();
iocContainer.import(registrations);
window.ioc=iocContainer;
platformBrowserDynamic().bootstrapModule(UserModule).then((module: any)=>{
});