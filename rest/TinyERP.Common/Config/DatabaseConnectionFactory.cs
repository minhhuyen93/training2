using System;
using TinyERP.Common.Common.Data;

namespace TinyERP.Common.Config
{
    public class DatabaseConnectionFactory
    {
        internal static ConnectionString Create(DatabaseConnectionElement databaseConnectionElement)
        {
            return new ConnectionString(databaseConnectionElement);
        }
    }
}
