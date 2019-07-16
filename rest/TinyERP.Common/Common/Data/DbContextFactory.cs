using System;
using System.Reflection;
using TinyERP.Common.Common.Attribute;
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

        public static IDbContext CreateContext<TEntity>()
        {
            DbContextAttribute dbContextAttribute = ObjectHelper.GetAttribute<DbContextAttribute>(typeof(TEntity));
            if (dbContextAttribute == null || dbContextAttribute.Use == null)
            {
                throw new Exception("Can not create DbContext");
            }
            MethodInfo createMethod = typeof(DbContextFactory).GetMethod("Create", BindingFlags.Static | BindingFlags.InvokeMethod | BindingFlags.Public);
            MethodInfo genericMethod = createMethod.MakeGenericMethod(new[] { dbContextAttribute.Use });

            IDbContext dbContext = (IDbContext)genericMethod.Invoke(null, new object[] { });

            return dbContext;
        }
    }
}
