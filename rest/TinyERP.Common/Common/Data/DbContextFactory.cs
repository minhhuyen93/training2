using System;
using TinyERP.Common.Common.Helper;

namespace TinyERP.Common.Common.Data
{
    public class DbContextFactory
    {
        public static IDbContext Create<IDbContext>()
        {
            Type dbType = AssemblyHelper.GetType<IDbContext>();
            return AssemblyHelper.CreateInstance<IDbContext>(dbType);
        }
    }
}
