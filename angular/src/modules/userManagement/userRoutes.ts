import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import {AppCommonModule} from "../common/commonModule";
import {Users} from "./pages/users";
import { CommonModule } from "@angular/common";
import { FormsModule } from "@angular/forms";
import {UserPreview} from "./_shared/components/userPreview";
import { HttpModule } from "@angular/http";
import {AddNewUser} from "./pages/addNewUser";
import {UserGroups} from "./pages/userGroups";
let routes: Routes = [
    {path:'', redirectTo:'users', pathMatch:'full'},
    {path:'users', component: Users},
    {path:'addNewUser', component: AddNewUser},
    {path:"usergroups", component : UserGroups}
];
@NgModule({
    imports: [CommonModule, HttpModule, FormsModule, RouterModule.forRoot(routes), AppCommonModule],
    declarations:[
        Users, UserPreview, AddNewUser, UserGroups
    ],
    exports: [RouterModule]
})
export class UserRoutes { }