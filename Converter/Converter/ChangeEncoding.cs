using System;
using System.Text;

namespace Converter
{
	/// <summary>
	/// Класс для изменения кодироки 
	/// </summary>
	class ChangeEncoding
	{
        internal static string SetEncoding(string JsonString, string EncodingName)
        {

			try
			{
				Encoding u8 = Encoding.UTF8;
				Encoding w1 = Encoding.GetEncoding(EncodingName);//"Windows-1251"
				byte[] utf8Bytes = u8.GetBytes(JsonString);
				byte[] w1B = Encoding.Convert(u8, w1, utf8Bytes);
				return w1.GetString(w1B);
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
				return null;
			}
        }
    }
}
