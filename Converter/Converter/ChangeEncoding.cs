using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
	class ChangeEncoding
	{
        public static string SetEncoding(string JsonString, string EncodingName)
        {
            Encoding u8 = Encoding.UTF8;
            Encoding w1 = Encoding.GetEncoding(EncodingName);//"Windows-1251"
            byte[] utf8Bytes = u8.GetBytes(JsonString);
            byte[] w1B = Encoding.Convert(u8, w1, utf8Bytes);
            return w1.GetString(w1B);
        }
    }
}
