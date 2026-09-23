using lab1;

namespace unitTest1
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var expected = 48;
            task1 myTask = new task1(2, 4, 6);
            var actual = myTask.calculate();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var expected = 81;
            task1 myTask = new task1(1, 3, 5);
            var actual = myTask.calculate();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var expected = -48;
            task1 myTask = new task1(-2, -4, -6);
            var actual = myTask.calculate();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var expected = 0;
            task1 myTask = new task1(0, 2, 4);
            var actual = myTask.calculate();
            Assert.AreEqual(expected, actual);
        }
    }
}
