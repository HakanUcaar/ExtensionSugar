using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionSugar
{
    public static class ReflectionExtSugars
    {
        public static PropertyInfo GetProperty<T>(this T ClassObject, string PropName) where T : class
        {
            return ClassObject.GetType().GetProperty(PropName);
        }
        public static object GetPropertyValue<T>(this T ClassObject, string PropName) where T : class
        {
            return ClassObject.GetProperty(PropName).GetValue(ClassObject);
        }
    }
}
