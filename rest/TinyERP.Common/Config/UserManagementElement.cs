namespace TinyERP.Common.Config
{
    using System.Configuration;
    public class UserManagementElement : ConfigurationElement
    {
        [ConfigurationProperty("apiEndpoint")]
        public string ApiEndpoint => (string)this["apiEndpoint"];

        [ConfigurationProperty("integrationMode")]
        public IntegrationModeType IntegrationMode => (IntegrationModeType)this["integrationMode"];
    }
}
