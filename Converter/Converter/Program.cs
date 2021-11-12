using ChoETL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
	class Program
	{
		static void Main(string[] args)
		{
            string JsonPath;
            string CsvPath; // if csv will be null , csvpath = jsonpath
            string Encoding;

            //снанчала путь входного файла -i  , кодировка -e  , разделитель полей (не поинмаю ) -s, путь выходного файла -o

            string pathtojson = "JSONforConvert.JSON";
            string pathtocsv = @"NEWCSV.csv";//программа сама определяет указан относительный или абсолютный путь


            string json = ReadFile(pathtojson);
            json = SetEncoding(json, "Windows-1251");

            WriteCSV(pathtocsv, json, pathtojson);

        }


        static string ReadFile(string path)
		{
            var sr = new StreamReader(path);

            string json = sr.ReadToEnd();

            return json;
        }

        static string SetEncoding(string JsonString , string EncodingName)
		{
            Encoding u8 = Encoding.UTF8;
            Encoding w1 = Encoding.GetEncoding(EncodingName);//"Windows-1251"
            byte[] utf8Bytes = u8.GetBytes(JsonString);
            byte[] w1B = Encoding.Convert(u8, w1, utf8Bytes);
            return w1.GetString(w1B);
        }

        static void WriteCSV(string PathToCSV , string JsonText , string PathToJSON)
		{
            if(PathToCSV != null)
			{
                File.WriteAllText(PathToCSV, JsonText);
            }
			else
			{
                string[] NewPathToCSV = PathToJSON.Split('.');

                File.WriteAllText(NewPathToCSV[0] + ".csv", JsonText);
            }
        }
    }
}
