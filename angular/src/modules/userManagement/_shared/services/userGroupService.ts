import { IUserGroupService } from "./iuserGroupService";
import { Promise, PromiseFactory, IConnector, IoCNames } from "@app/common";

export class UserGroupService implements IUserGroupService{
    public getUserGroups():Promise{
        let uri:string="/rest/api/userGroups";
        let connector: IConnector = window.ioc.resolve(IoCNames.IConnector);
        return connector.get(uri);
    }
}