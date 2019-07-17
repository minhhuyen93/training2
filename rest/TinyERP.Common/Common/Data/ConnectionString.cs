using TinyERP.Common.Config;

namespace TinyERP.Common.Common.Data
{
    public class ConnectionString
    {
        public string Server { get; set; }
        public string Database { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public ConnectionString(DatabaseConnectionElement connection)
        {
            this.Server = connection.Server;
            this.Database = connection.Database;
            this.UserName = connection.UserName;
            this.Password = connection.Password;
        }
    }
}
