namespace TinyERP.Common.Common.Helper
{
    public class EnumHelper
    {
        internal static ITypeEnum Parse<ITypeEnum>(string enumKey)
        {
            return (ITypeEnum)System.Enum.Parse(typeof(ITypeEnum), enumKey);
        }
    }
}
