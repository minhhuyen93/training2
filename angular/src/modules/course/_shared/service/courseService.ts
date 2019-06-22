import { Promise, IConnector, IoCNames } from "@app/common";

export class CourseService {
    public getCourses(): Promise {
        let url: string = "rest/api/courses";
        let connector: IConnector = window.ioc.resolve(IoCNames.IConnector);
        return connector.get(url);
    }

    public createCourse(model: any): Promise {
        let url: string = "rest/api/courses";
        let connector: IConnector = window.ioc.resolve(IoCNames.IConnector);
        return connector.post(url, model);
    }
} 