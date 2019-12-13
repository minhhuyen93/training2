
using System.Collections.Generic;

namespace TinyERP.Common.Common.Application
{
    public interface IApplication
    {
        void OnApplicationStarting();
        void OnApplicationEnding();
        void OnApplicationErrors(IList<System.Exception> errors);
    }
}
