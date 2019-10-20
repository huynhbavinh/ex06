using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stack;

namespace UnitTestProject1
{
    [TestClass]
    public class StackTest
    {
        [TestMethod]
        public void CreatedMyStack()
        {
            myStack s1 = new myStack(10);
            s1.push(1);
            s1.push(2);
            s1.push(3);
            s1.push(4);
            Assert.AreEqual(4, s1.checkcount());
        }
        [TestMethod]
        public void checkPop()
        {
            myStack s2 = new myStack(10);
            s2.push(1);
            s2.push(2);
            s2.push(3);
            s2.push(4);
            Assert.AreEqual(4, s2.pop());
        }
        [TestMethod]
        public void checkPeek()
        {
            myStack s3 = new myStack(10);
            s3.push(1);
            s3.push(2);
            s3.push(3);
            s3.push(4);
            Assert.AreEqual(4, s3.peek());
        }
    }
}
