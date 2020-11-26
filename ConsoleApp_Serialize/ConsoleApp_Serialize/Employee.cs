using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime;
using System.Xml.Serialization;

namespace ConsoleApp_Serialize

{
	[Serializable]
	public class Employee
	{
		public int EmployeeID { get; set; }
		public string EmployeeName { get; set; }

		public int Age { get; set; }

		public double Salary { get; set; }
		public string Designation { get; set; }

		public void SerializeAddEmployee()
		{
			/*try
			{
				Employee objemployee = new Employee();
				Console.WriteLine("Enter employees Details :");
				Console.WriteLine("==============================");
				EmployeeID = Convert.ToInt32(Console.ReadLine());
				EmployeeName = Console.ReadLine();
				Age = Convert.ToInt32(Console.ReadLine());
				Salary = Convert.ToDouble(Console.ReadLine());
				Designation = Console.ReadLine();
				FileStream fs = new FileStream("D:\\myFile.xml", FileMode.OpenOrCreate, FileAccess.Write);
				//	BinaryFormatter bf = new BinaryFormatter();

				XmlSerializer xs = new XmlSerializer(typeof(Employee));
				xs.Serialize(fs, objemployee);
				fs.Close();
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}*/
			try
			{



				Employee objemployee = new Employee();
				Console.WriteLine("Enter Employee Details");
				Console.WriteLine("=======================================");
				objemployee.EmployeeID = Convert.ToInt32(Console.ReadLine());
				objemployee.EmployeeName = Console.ReadLine();
				objemployee.Age = Convert.ToInt32(Console.ReadLine());
				objemployee.Salary = Convert.ToDouble(Console.ReadLine());
				objemployee.Designation = Console.ReadLine();
				FileStream fs = new FileStream("D:\\myfile.xml", FileMode.OpenOrCreate, FileAccess.Write);
				//BinaryFormatter b = new BinaryFormatter();
				XmlSerializer xs = new XmlSerializer(typeof(Employee));

				xs.Serialize(fs, objemployee);
				fs.Close();
			}
			catch (Exception ex)
			{



				Console.WriteLine(ex.Message);
			}

			


		}

		public void Deserialize()
		{
			/*Console.WriteLine("do you want to serialize");
			Console.ReadLine();
			FileStream fs1 = new FileStream("D:\\SerializeTextFileEx.txt", FileMode.Open, FileAccess.Read);
			Employee objemployee = new Employee();
			BinaryFormatter b = new BinaryFormatter();
			objemployee = (Employee)b.Deserialize(fs1);

			objemployee.EmployeeID = objemployee.EmployeeID;
			Console.WriteLine("Eployeeid:" + EmployeeID);
			objemployee.EmployeeName = objemployee.EmployeeName;
			Console.WriteLine("Name:" + EmployeeName);




			Console.WriteLine(objemployee.EmployeeName);



			objemployee.Age = objemployee.Age;
			Console.WriteLine("age:" + Age);



			objemployee.Salary = objemployee.Salary;
			Console.WriteLine("salary:" + Salary);*/
		}






	}
}
