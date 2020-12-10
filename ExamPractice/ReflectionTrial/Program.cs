using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionTrial
{
	class Program
	{
		static void Main(string[] args)
		{
			Assembly assembly = Assembly.LoadFile("D:\\LabAssignments\\LabAssignment4\\LabAssignment4_1\\bin\\Debug\\LabAssignment1.dll");
			Type[] type = assembly.GetTypes();
			foreach(var item in type)
			{
				Console.WriteLine("Class : " + item.Name);
				MethodInfo[] mi = item.GetMethods();
				foreach(var method in mi)
				{
					Console.WriteLine("Methods : " + method.Name);
					ParameterInfo[] parameter = method.GetParameters();
					foreach(var parameters in parameter)
					{
						Console.WriteLine("Parameters are :" + parameters.Name);
					}
				}
			}
		}
	}
}
