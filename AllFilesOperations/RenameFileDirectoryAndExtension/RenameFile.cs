using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RenameFileDirectoryAndExtension
{
	public static class RenameFileclassExample
	{
		public static void RenameDirectoryExample()
		{
			try
			{

			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
		
		//FileStream fs1 = new FileStream(path,FileMode.Open, FileAccess.Read);
		public static  void RenameFileOrDirectory(this FileInfo fileinfo,string newname)
		{
			try
			{
				
					fileinfo.MoveTo(Path.Combine(fileinfo.Directory.FullName, newname));
				
			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message);
			}
		}
		
	}
}
