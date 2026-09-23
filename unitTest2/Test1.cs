using lab1;

namespace unitTest2
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var myTask = new task2(10, 5);
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => myTask.calculateSum());
        }

        [TestMethod]
        public void TestMethod2() 
        {
            var myTask = new task2(1, 1);
            var expected = 0;
            var actual = myTask.calculateSum();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3() 
        {
            var myTask = new task2(0, 100);
            var expected = 75;
            var actual = myTask.calculateSum();
            Assert.AreEqual(expected, actual);
        }
    }
}
