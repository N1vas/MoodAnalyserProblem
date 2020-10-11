using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodeAnalyseAndExceptional;
namespace MoodAnalyseTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("I am in Sad Mood")]
        [DataRow("I am in Happy Mood")]
        public void TestMethod1(string message)
        {
            //Arrange
            string expected = "SAD";
            MoodAnalyse mood = new MoodAnalyse(message);
            //Act
            var result = mood.analyseMood();
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
