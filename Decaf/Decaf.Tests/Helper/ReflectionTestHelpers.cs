using System.Reflection;

namespace Decaf.Tests.Helper
{
    public static class ReflectionTestHelpers
    {
        public static bool ContainsType(this Assembly assembly, string className)
        {
            var type = assembly.GetType(className);
            return type != null;
        }

        public static bool ContainsTypeWithMethod(this Assembly assembly, string className, string methodName)
        {
            var type = assembly.GetType(className);
            if(type == null) return false;

            var method = type.GetMethod(methodName);
            return method != null;
        }
    }
}