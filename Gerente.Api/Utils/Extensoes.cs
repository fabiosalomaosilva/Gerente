using System;
using static System.Convert;

namespace Gerente.Api.Utils
{
    public static class Extensoes
    {
        public static int ToInt(this string text)
        {
            return ToInt32(text);
        }

        public static bool ToBool(this string text)
        {
            return ToBoolean(text);
        }

        public static Guid ToGuid(this string text)
        {
            return ToGuid(text);
        }

        public static string GetFirstName(this string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                var array = text.Split(' ');
                return array[0];
            }

            return string.Empty;
        }
    }
}
