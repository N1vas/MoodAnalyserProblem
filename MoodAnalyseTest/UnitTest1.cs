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
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            string message = null;
            object expected = new MoodAnalyse(message);
            object obj = MoodAnalyseFactory.CreateMoodAnalyser("MoodeAnalyseAndExceptional.MoodAnalyse", "MoodAnalyse");
            expected.Equals(obj);

        }
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject_UsingParameterizedConstructor()
        {
            object expected = new MoodAnalyse("HAPPY");
            object obj = MoodAnalyseFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyserAppWithCoreLive1.MoodAnalyser", "MoodAnalyser", "SAD");
            expected.Equals(obj);
        }
    }
}
