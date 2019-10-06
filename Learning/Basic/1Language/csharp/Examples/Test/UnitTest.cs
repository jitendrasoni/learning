using NUnit.Framework;

namespace Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void Example1_FirstTest_Valiedate_Function()
        {
            var example1 = new Library.Example1();
            Assert.AreEqual("test", example1.UnitTest("test"));
        }
    }
}