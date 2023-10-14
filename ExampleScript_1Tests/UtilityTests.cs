using Microsoft.VisualStudio.TestTools.UnitTesting;

using Moq;

using Skyline.DataMiner.Automation;

namespace ExampleScript_1.Tests
{
	[TestClass()]
	public class UtilityTests
	{
		[TestMethod()]
		public void ExampleTestMethod()
		{
			// Arrange
			var engine = new Mock<IEngine>();

			// Act
			var result = Utility.ToUpper("b", engine.Object);

			engine.Verify(d => d.GenerateInformation("B"));

			Assert.AreEqual("B", result);
		}
	}
}