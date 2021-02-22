using System;

namespace ReversingString
{
    public class StringUtilities
    {
        public static string Reverse(string s)
        {
            char[] chars = s.ToCharArray();
            int x = chars.Length - 1;

            for (int i = 0; i < chars.Length / 2; i++)
            {
                char tempV = chars[i];
                chars[i] = chars[x];
                chars[x] = tempV;

                x--;

            }

            return new string(chars);

            throw new NotImplementedException();
        }
    }
}
