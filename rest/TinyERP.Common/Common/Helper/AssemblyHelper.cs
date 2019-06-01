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
            IList<string> assemblys = AssemblyHelper.GetApplicationDlls();
            IList<Type> types = new List<Type>();
            foreach (string file in assemblys)
            {
                IList<System.Type> assemblyTypes = Assembly.Load(file).GetTypes().Where(item => !item.IsAbstract && item.IsClass && typeof(ITask).IsAssignableFrom(item)).ToList();
                types = types.Concat(assemblyTypes).ToList();

            }
            if (types.Count() == 0) { return; }
            foreach (Type item in types)
            {
                ITask task = AssemblyHelper.CreateInstance<ITask>(item);
                task.Execute();
            }
        }

        private static ITask CreateInstance<ITask>(Type type) where ITask : IBaseTask
        {
            object result = Activator.CreateInstance(type, new object[] { });
            return (ITask)result;
        }

        private static string GetBinDirectory()
        {
            var binFolderPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().EscapedCodeBase).Replace("file:\\", string.Empty);
            return binFolderPath;
        }

        public static IList<string> GetApplicationDlls(string filePattern="*.dll")
        {
            var binFolder = AssemblyHelper.GetBinDirectory();
            IList<string> files = Directory.GetFiles(binFolder, filePattern).Where(file => file.StartsWith("TinyERP.")).Select(fileItem => Path.GetFileNameWithoutExtension(fileItem)).ToList();
            return files;
        }
    }
}