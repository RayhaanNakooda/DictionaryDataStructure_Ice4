using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryDataStructure
{
    public class DictionaryClass
    {

        public static Dictionary<string, object> dict;
        public static void Add(string strKey, object dataType)
        {
            if (!dict.ContainsKey(strKey))
            {
                dict.Add(strKey, dataType);
            }
            else
            {
                dict[strKey] = dataType;
            }
        }

        public static T GetAnyValue<T>(string strKey)
        {
            object obj;
            T retType;
            dict.TryGetValue(strKey, out obj);

            try
            {
                retType = (T)obj;
            }
            catch
            {
                retType = default(T);
            }
            return retType;

        }
    }
}
