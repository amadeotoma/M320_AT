using Microsoft.VisualStudio.TestTools.UnitTesting;
using Browsersimulator;

namespace Browsersimulator.Tests
{
    [TestClass]
    public class StringStackTests
    {
        [TestMethod]
        public void TestPush()
        {
            StringStack stack = new StringStack(3);
            stack.Push("Value1");

            Assert.AreEqual("Value1", stack.Pop());
        }

        [TestMethod]
        public void TestPop()
        {
            StringStack stack = new StringStack(3);
            stack.Push("Value1");
            stack.Push("Value2");

            Assert.AreEqual("Value2", stack.Pop());
        }

        [TestMethod]
        public void TestPeek()
        {
            StringStack stack = new StringStack(3);
            stack.Push("Value1");
            stack.Push("Value2");

            Assert.AreEqual("Value2", stack.Peek());
            Assert.AreEqual("Value2", stack.Pop());
        }

        [TestMethod]
        public void TestSwap()
        {
            StringStack stack = new StringStack(3);
            stack.Push("Value1");
            stack.Push("Value2");

            stack.Swap();

            Assert.AreEqual("Value1", stack.Pop());
            Assert.AreEqual("Value2", stack.Pop());
        }

        [TestMethod]
        public void TestClear()
        {
            StringStack stack = new StringStack(3);
            stack.Push("Value1");
            stack.Push("Value2");

            stack.Clear();

            Assert.IsTrue(stack.IsEmpty);
        }

        [TestMethod]
        public void TestIsEmpty()
        {
            StringStack stack = new StringStack(3);

            Assert.IsTrue(stack.IsEmpty);

            stack.Push("Value1");

            Assert.IsFalse(stack.IsEmpty);
        }

        [TestMethod]
        public void TestCount()
        {
            StringStack stack = new StringStack(3);
            stack.Push("Value1");
            stack.Push("Value2");

            Assert.AreEqual(2, stack.Count);
        }

        [TestMethod]
        public void TestIsFull()
        {
            StringStack stack = new StringStack(2);
            stack.Push("Value1");
            stack.Push("Value2");

            Assert.IsTrue(stack.IsFull);
        }
    }
}