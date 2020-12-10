using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTestingDemo;

namespace UnitTestProject1
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			Program p = new Program();
			int kk = p.add(10,20);
			Assert.AreEqual(30, kk);
		}
		[TestMethod]
		public void testMethod2()
		{
			Program p = new Program();
			int sb = p.Sub(20, 10);
			Assert.AreEqual(10, sb);
		}
	}
}
