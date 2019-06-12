namespace TinyERP.Common.Common.Helper
{
    using TinyERP.Common.Common.Task;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.IO;

    public class AssemblyHelper
    {
        public static void Execute<ITask>() where ITask : IBaseTask
        {
            IList<string> applicationDlls = AssemblyHelper.GetApplicationDlls();
            IList<Type> types = new List<Type>();
            foreach (var assembly in applicationDlls)
            {
                IList<Type> fileTypes = Assembly.Load(assembly).GetTypes().Where(item => !item.IsAbstract && item.IsClass && typeof(ITask).IsAssignableFrom(item)).ToList();
                types = types.Concat(fileTypes).ToList();
            }
            if (types.Count() == 0) { return; }
            foreach (var type in types)
            {
                ITask task = AssemblyHelper.CreateInstance<ITask>(type);
                task.Execute();
            }
        }

        private static ITask CreateInstance<ITask>(Type type) where ITask : IBaseTask
        {
            object result = Activator.CreateInstance(type, new object[] { });
            return (ITask)result;
        }

        private static IList<string> GetApplicationDlls(string filePattern="*.dll")
        {
            var binPath = AssemblyHelper.GetBinDirectoryPath();
            IList<string> dlls = Directory.GetFiles(binPath, filePattern)
                .Where(item => Path.GetFileName(item).StartsWith("TinyERP."))
                .Select(fileItem => Path.GetFileNameWithoutExtension(fileItem))
                .ToList();
            return dlls;
        }

        private static string GetBinDirectoryPath()
        {
            var binPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().EscapedCodeBase).Replace("file:\\", string.Empty);
            return binPath;
        }
    }
}