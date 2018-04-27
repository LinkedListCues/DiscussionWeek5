using System;
using DiscussionWeek5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BSTTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MaxTest () {
            BinarySearchTreeNode t = new BinarySearchTreeNode(5,
                new BinarySearchTreeNode(3, new BinarySearchTreeNode(1), new BinarySearchTreeNode(4)),
                new BinarySearchTreeNode(9, new BinarySearchTreeNode(6), new BinarySearchTreeNode(11, null, new BinarySearchTreeNode(99))));

            Assert.AreEqual(BinarySearchTreeNode.maximum(t).Value, 99);
        }
    }
}
