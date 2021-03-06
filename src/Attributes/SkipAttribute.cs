using System;
using System.Linq;
using System.Reflection;


namespace NValidate.Attributes
{
    /// <summary>
    /// Marks a validation method as needing to be skipped.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    public class SkipAttribute : Attribute
    {
        public static bool HasAttribute(TypeInfo typeInfo) => typeInfo.GetCustomAttributes(typeof(SkipAttribute), true).Count() > 0;
        public static bool HasAttribute(MethodInfo methodInfo) => methodInfo.GetCustomAttributes(typeof(SkipAttribute), true).Count() > 0;
    }
}