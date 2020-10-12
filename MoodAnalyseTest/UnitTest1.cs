using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodeAnalyseAndExceptional;
namespace MoodAnalyseTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(null)]
        public void TestMethod1(string message)
        {
            //Arrange
            string expected = "HAPPY";
            MoodAnalyse mood = new MoodAnalyse(message);
            //Act
            var result = mood.analyseMood();
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
