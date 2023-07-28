using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExampleScript_1.Tests
{
	[TestClass()]
	public class UtilityTests
	{
		[TestMethod()]
		public void ToUpperTest()
		{
			// Act
			var result = Utility.ToUpper("b");

			Assert.AreEqual("B", result);
		}
	}
}