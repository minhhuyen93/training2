using System.Configuration;

namespace TinyERP.Common.Config
{
    public class Configuration : System.Configuration.ConfigurationSection
    {
        private static Configuration _instance;
        public static Configuration Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = (Configuration)System.Configuration.ConfigurationManager.GetSection("tinyerpConfiguration");
                }
                return _instance;
            }
        }
        [ConfigurationProperty("userManagement")]
        public UserManagementElement UserManagement
        {
            get
            {
                return (UserManagementElement)this["userManagement"];
            }
        }
        [ConfigurationProperty("userMangementDbContext")]
        public UserManagementDbContextElement UserManagementDbContext
        {
            get
            {
                return (UserManagementDbContextElement)this["userMangementDbContext"];
            }
        }
        [ConfigurationProperty("databaseConnections")]
        [ConfigurationCollection(typeof(DatabaseConnectionElement), AddItemName = "add", RemoveItemName = "remove", ClearItemsName = "clear")]
        public DatabaseConnectionsElement DatabaseConnections
        {
            get
            {
                return (DatabaseConnectionsElement)this["databaseConnections"];
            }
        }
    }
}
