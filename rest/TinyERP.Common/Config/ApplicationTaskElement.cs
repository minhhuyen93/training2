using System.Configuration;

namespace TinyERP.Common.Config
{
    public class ApplicationTaskElement : ConfigurationElement
    {
        [ConfigurationProperty("name", IsKey = true, IsRequired = true)]
        public string Name
        {
            get
            {
                return (string)this["name"];
            }
        }
        [ConfigurationProperty("enable", IsRequired = true, DefaultValue = true)]
        public bool Enable
        {
            get
            {
                return (bool)this["enable"];
            }
        }
    }
}
