using JenkinsProject.Models.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Utility.Tests
{
    [TestClass]
    public class UtilityTest
    {
        [TestMethod]
        public void AdditionTest()
        {
            var mathOperation = new MathOperation();

            var x = 10;
            var y = 20;
            var result = mathOperation.Addition(x, y);

            Assert.AreEqual(result, 30);
        }
    }
}
