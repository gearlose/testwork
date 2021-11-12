using System;
using System.Linq;

namespace Converter
{
    class Program
    {

        static void Main(string[] args)
        {
            string JsonPath = "";
            string CsvPath = ""; // if csv will be null , csvpath = jsonpath
            string EncodingType = "";
            string Separator = "";


            for (int i = 0; i < args.Length; i++)
            {
                try
                {
                    Console.WriteLine(args[i]);
                    if (args[i] == "-i")
                        JsonPath = args[i + 1];
                    else if (args[i] == "-e")
                        EncodingType = args[i + 1];
                    else if (args[i] == "-o")
                        CsvPath = args[i + 1];
                    else if (args[i] == "-s")
                        Separator = args[i + 1];
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            string JsonText = WorkWithFiles.ReadFile(JsonPath);

            if (!String.IsNullOrEmpty(JsonText))
			{
                if (!String.IsNullOrEmpty(EncodingType))
                {
                    JsonText = ChangeEncoding.SetEncoding(JsonText, EncodingType);
                }

                if (!String.IsNullOrEmpty(Separator))
                {
                    JsonText = TypeSeparator.ChangeSepType(JsonText, Separator);
                }

                WorkWithFiles.WriteCSV(CsvPath, JsonText, JsonPath);
            }


            if (args.Contains("-q"))
			{
                Console.WriteLine("The program is completed");
                Console.ReadKey();
            }
        }
    }
}
