using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Base.Server.Util
{
    public class Utils
    {
        public static T GetAttribute<T>(Type target)
            where T : Attribute
        {
            T attribute = (from a in target.GetCustomAttributes(typeof(T), true)
                           select (a as T)).SingleOrDefault();

            return attribute;
        }

        public static PropertyInfo[] GetPropertiesToTytpe<T>()
            where T : class, new()
        {
            PropertyInfo[] properties = typeof(T).GetProperties();
            return properties;
        }
    }
}
