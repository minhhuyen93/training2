using System.Net.Http;
using TinyERP.Common.Common.Connector;
using TinyERP.Common.Common.Data;
using TinyERP.Common.Common.Helper;
using TinyERP.UserManagement.Share.Dto;

namespace TinyERP.UserManagement.Share.Facade
{
    internal class RemoteUserManagementFacade : IUserManagementFacade
    {
        public int CreateUserIfNotExisted(CreateUserRequest createUserRequest)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = httpClient.PostAsync($"http://usermanagement.tinyerp.com/api/users/create-if-not-exist", new JsonContent<CreateUserRequest>(createUserRequest)).Result;
            response.EnsureSuccessStatusCode();
            string result = response.Content.ReadAsStringAsync().Result;
            int userId = 0;
            ResponseData responseData = JsonHelper.ToObject<ResponseData>(result);
            userId = int.Parse(responseData.Data.ToString());
            return userId;
        }
    }
}
