using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("ojmveopmrobenrm");

            Console.WriteLine(sb.Substring(2, 5));
        }
    }

    public static class Extensions
    {
        public static StringBuilder Substring(this StringBuilder sb, int startIndex, int length)
        {
            if (startIndex + length > sb.Length || startIndex < 0 || startIndex > sb.Length)
            {
                throw new ArgumentOutOfRangeException("Substring goes outside the bounds of the string");
            }

            char[] substring = new char[length];
            StringBuilder newSubstring = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                substring[i] = sb[startIndex + i];
            }
            
            newSubstring.Append(substring);
    
            return newSubstring;
        }
    }
}
