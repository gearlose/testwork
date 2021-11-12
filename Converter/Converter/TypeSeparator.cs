using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
	class TypeSeparator
	{
		public static string ChangeSepType(string JsonText , string Separator)
		{
			if (JsonText != null)
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
			else
				return null;
		}
	}
}
