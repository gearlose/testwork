using System;
using System.Text;

namespace Converter
{
	/// <summary>
	/// Класс для изменения разделителя в csv файле
	/// </summary>
	class TypeSeparator
	{
		internal static string ChangeSepType(string JsonText, string Separator)
		{
			if(Separator[0] == '-')//проверка на то , что аргумент не принял следующий аргумент за текст
			{
				return JsonText;
			}
			try
			{
				StringBuilder sb = new StringBuilder();
				foreach (char nextChar in JsonText)
				{

					if (nextChar == ',')
						sb.Append(Separator);
					else
						sb.Append(nextChar);
				}

				return sb.ToString();
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
				return JsonText;
			}
		}
	}
}
