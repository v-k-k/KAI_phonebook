using System;
using System.Collections.Generic;
using System.Linq;

namespace KAI_phonebook
{
    /// <summary>
    /// Collection of handy utils
    /// </summary>
    public static class EnumUtil
    {
        public static IEnumerable<T> GetValues<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }
    }
}
