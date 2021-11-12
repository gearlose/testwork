using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
	class WorkWithFiles
	{
		public static string ReadFile(string path)
		{
			var sr = new StreamReader(path);

			string json = sr.ReadToEnd();

			return json;
		}

		public static void WriteCSV(string pathtocsv, string jsontext, string pathtojson)
		{
			if (pathtocsv != null)
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
