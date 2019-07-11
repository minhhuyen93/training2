namespace TinyERP.Common.Common.Attribute
{
    using System;
    public class DbContext : System.Attribute
    {
        public Type Use { get; set; }
    }
}
