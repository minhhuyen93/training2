using TinyERP.Common.Common.Exceptions;

namespace TinyERP.Common.Common.Application
{
    public class ApplicationFactory
    {
        public static IApplication Create(ApplicationType type)
        {
            switch (type)
            {
                case ApplicationType.WebApi:
                    return new WebApplication();
                default:
                    throw new UnSupportException("Unsupport Application Type");
            }
        }
    }
}
