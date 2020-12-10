using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializationExamples
{
	[Serializable]
	class Student
	{
		public int RollNumber { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }

		//XML Serialization
		public void XMLSerialization()
		{
			Student stObj = new Student()
			{
				RollNumber = 1,
				Name = "sonal",
				Age = 22
			};

			FileStream fs = new FileStream(@"Serializationxmlser.xml", FileMode.OpenOrCreate, FileAccess.Write);
			XmlSerializer xmlser = new XmlSerializer(typeof(Student));
			xmlser.Serialize(fs, stObj);
			fs.Close();
			Console.WriteLine("XML Serialization Completed.");
		}
	}

}