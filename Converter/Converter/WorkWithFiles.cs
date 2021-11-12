using System;
using System.IO;

namespace Converter
{
	/// <summary>
	/// Класс для работы с файлами
	/// </summary>
	class WorkWithFiles
	{
		internal static string ReadFile(string path)
		{
			try
			{
				var sr = new StreamReader(path);

				string json = sr.ReadToEnd();

				return json;
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
				return null;
			}


		}

		internal static void WriteCSV(string pathtocsv, string jsontext, string pathtojson)
		{
			if (!String.IsNullOrEmpty(pathtocsv))
			{
				File.WriteAllText(pathtocsv, jsontext);
			}
			else
			{
				string[] newpathtocsv = pathtojson.Split('.');

				File.WriteAllText(newpathtocsv[0] + ".csv", jsontext);
			}
		}
	}
}
