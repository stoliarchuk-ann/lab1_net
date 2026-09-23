using lab1;

namespace unitTest3
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var expected = 235.619;
            task3 myTask = new task3(10, 5);
            var actual = myTask.calculateArea();
            Assert.AreEqual(expected, actual, 0.001);
        }

        [TestMethod]
        public void TestMethod2()
        {
            task3 myTask = new task3(5, 10);
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => myTask.calculateArea());
        }

        [TestMethod]
        public void TestMethod3()
        {
            var expected = 7.5;
            task3 myTask = new task3(10, 5);
            var actual = myTask.calculateAvgRadius();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod4()
        {
            task3 myTask = new task3(-10, 5);
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => myTask.calculateAvgRadius());
        }

        [TestMethod]
        public void TestMethod5()
        {
            var expected = 5;
            task3 myTask = new task3(10, 5);
            var actual = myTask.calculateWidth();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod6()
        {
            var expected = 0;
            task3 myTask = new task3(5, 5);
            var actual = myTask.calculateWidth();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod7()
        {
            task3 myTask = new task3(2, 5);
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => myTask.calculateWidth());
        }
    }
}
