
using System.Configuration;

namespace TinyERP.Common.Config
{
    public class UserManagementDbContextElement : ConfigurationElement
    {
        [ConfigurationProperty("name")]
        public string Name => (string)this["name"];
        [ConfigurationProperty("connectionString")]
        public string ConnectionString => (string)this["connetionString"];
        [ConfigurationProperty("providerName")]
        public string ProviderName => (string)this["providerName"];
    }
}
