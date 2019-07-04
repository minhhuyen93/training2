using System.Net.Http;
using TinyERP.Common.Common.Connector;
using TinyERP.Common.Common.Data;
using TinyERP.Common.Common.Helper;
using TinyERP.UserManagement.Share.Dto;
using System.Configuration;

namespace TinyERP.UserManagement.Share.Facade
{
    public class RemoteUserManagementFacade : IUserManagementFacade
    {
        public int CreateUserIfNotExisted(CreateUserRequest createUserRequest)
        {
            HttpClient httpClient = new HttpClient();
            string urlEndpoint = TinyERP.Common.Config.Configuration.Instance.UserManagement.ApiEndpoint;//ConfigurationManager.AppSettings["UserManagementApi"] + "/create-if-not-exist";
            HttpResponseMessage response = httpClient.PostAsync(urlEndpoint, new JsonContent<CreateUserRequest>(createUserRequest)).Result;
            response.EnsureSuccessStatusCode();
            string result = response.Content.ReadAsStringAsync().Result;
            int userId = 0;
            ResponseData responseData = JsonHelper.ToObject<ResponseData>(result);
            userId = int.Parse(responseData.Data.ToString());
            return userId;
        }
    }
}
