using NUnit.Framework;
using MoodAnalyzer;

namespace Test1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("I am in Sad Mood")]
        public void Test1_Passingvalid_input_ReturnTrue(string input1)
        {
            Moodanalyser n=new Moodanalyser(input1);
            string expected = "Sad";

            var actual = n.AnalyseMood();
            Assert.AreEqual(expected, actual);
        }
       
        [TestCase("I am in Happy Mood")]
        public void Test2_Passingvalid_input_ReturnTrue(string input2)
        {
            Moodanalyser v=new Moodanalyser(input2);
            string expected = "Happy";
            var actual = v.AnalyseMood();
            Assert.AreEqual(expected, actual);
        }
    }
}