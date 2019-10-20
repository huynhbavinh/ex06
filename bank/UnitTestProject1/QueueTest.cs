using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyQueue;


namespace UnitTestProject1
{
    [TestClass]
    public class QueueTest
    {
        [TestMethod]
        public void TestCreatQueue()
        {
            queue u1 = new queue(10);
            u1.Enqueue(1);
            u1.Enqueue(2);
            u1.Enqueue(3);
            u1.Enqueue(4);
            Assert.AreEqual(4, u1.checkCount());
        }
        [TestMethod]
        public void TestDequeue()
        {
            queue u2 = new queue(10);
            u2.Enqueue(1);
            u2.Enqueue(2);
            u2.Enqueue(3);
            u2.Enqueue(4);
            Assert.AreEqual(1, u2.Dequeue());
            Assert.AreEqual(2, u2.Dequeue());
        }
        [TestMethod]
        public void TestPeekVCount()
        {
            queue u3 = new queue(10);
            u3.Enqueue(1);
            u3.Enqueue(2);
            u3.Enqueue(3);
            Assert.AreEqual(1, u3.peek());
            Assert.AreEqual(3, u3.checkCount());
        }

    }
}
