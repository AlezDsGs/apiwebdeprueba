using NUnit.Framework;

namespace UnitTest
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
            //peque�o cambio
            Assert.AreEqual(1,1);
        }
    }
}