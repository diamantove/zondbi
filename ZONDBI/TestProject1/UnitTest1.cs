namespace TestProject1
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
            Assert.IsTrue(1 == 1);
        }

        [Test]
        public void Test2()
        {
            int two = 1 + 1;
            Assert.IsTrue(two == 2);
        }

        [Test]
        public void Test3()
        {
            int i = 1;
            Assert.IsTrue(i == 1);
        }
    }
}