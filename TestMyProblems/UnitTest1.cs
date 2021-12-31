using Microsoft.VisualStudio.TestTools.UnitTesting;
using MediumProblems;

namespace TestMyProblems
{
	[TestClass]
	public class UnitTest1
	{
		string[] testerStrings = { };
		[TestMethod]
		public void TestMethod1()
		{
			MediumProblems.MediumMain.Main(testerStrings);
		}
	}
}