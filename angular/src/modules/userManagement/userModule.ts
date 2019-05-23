import { NgModule, ApplicationRef, Injector } from "@angular/core";
import { BrowserModule } from "@angular/platform-browser";
import { FormsModule } from "@angular/forms";
import { UserRoutes } from "./userRoutes";
import { Layout } from "../../layout";
import { IAppSettingService } from "@app/common";
import { IoCNames } from "@app/common";
import {IResourceManager} from "@app/common";
@NgModule({
    imports: [
        BrowserModule,
        FormsModule,
        UserRoutes
    ],
    declarations: [Layout],
    entryComponents:[Layout]
})
export class UserModule {
    private appRef:ApplicationRef;
    constructor(appRef:ApplicationRef, injector: Injector){
        let appSettingService:IAppSettingService = window.ioc.resolve(IoCNames.IAppSettingService);
        appSettingService.setInjector(injector);
        this.appRef=appRef;
    }
    ngDoBootstrap(){
        let self=this;
        let locales:Array<string>=["common", "users", "addNewUser", "userGroups"];
        let resourceManager:IResourceManager = window.ioc.resolve(IoCNames.IResourceManager);
        resourceManager.load(locales).then(()=>{
            self.appRef.bootstrap(Layout);
        });
        
    }
}