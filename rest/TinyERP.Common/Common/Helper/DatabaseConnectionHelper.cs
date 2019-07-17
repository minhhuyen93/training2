using System;
using TinyERP.Common.Common.Data;
using TinyERP.Common.Common.Exceptions;
using TinyERP.Common.Config;

namespace TinyERP.Common.Common.Helper
{
    public class DatabaseConnectionHelper
    {
        public static ConnectionString GetConnection<TDbType>()
        {
            string idbContextName = typeof(TDbType).FullName;
            DatabaseConnectionElement databaseConnectionElement = Configuration.Instance.DatabaseConnections[idbContextName];
            if (databaseConnectionElement == null)
            {
                throw new UnSupportException("System does not support this type db Context");
            }
            return DatabaseConnectionFactory.Create(databaseConnectionElement);
        }
    }
}
