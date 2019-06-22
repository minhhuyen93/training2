import { Promise, IConnector, IoCNames } from "@app/common";

export class CourseService {
    public getCourses(): Promise {
        let url: string = "http://course.tinyerp.com/api/courses";
        let connector: IConnector = window.ioc.resolve(IoCNames.IConnector);
        return connector.get(url);
    }

    public createCourse(model: any): Promise {
        let url: string = "http://course.tinyerp.com/api/courses";
        let connector: IConnector = window.ioc.resolve(IoCNames.IConnector);
        return connector.post(url, model);
    }
} 