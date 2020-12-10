using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionDemo
{
	static class stringExtension
{
		public static string RemoveNumeric(this string s) {
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < s.Length; i++)
			{
				if (char.IsDigit(s[1]))
					sb.Append(s[i]);
			}
			return sb.ToString();
		}
}

	class Program
	{
		static void Main(string[] args)
		{
			string phone = "123-123-1234";

			//stringExtension sr=new stringExtension()

			string newPhone = phone.RemoveNumeric();
			Console.WriteLine(newPhone);
		}
	}
}
