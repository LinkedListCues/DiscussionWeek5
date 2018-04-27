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

        [TestMethod]
        public void MaxEqualsTest () {
            // Test with two equal nodes corresponding to the same maximum.
            BinarySearchTreeNode t = new BinarySearchTreeNode(5,
                new BinarySearchTreeNode(3, new BinarySearchTreeNode(1), new BinarySearchTreeNode(4)),
                new BinarySearchTreeNode(9, new BinarySearchTreeNode(6), new BinarySearchTreeNode(11, null,
                    new BinarySearchTreeNode(99, new BinarySearchTreeNode(99), null))));

            Assert.AreEqual(BinarySearchTreeNode.maximum(t).Value, 99);
        }

        [TestMethod]
        public void MinTest () {
            BinarySearchTreeNode t = new BinarySearchTreeNode(5,
                new BinarySearchTreeNode(3, new BinarySearchTreeNode(1), new BinarySearchTreeNode(4)),
                new BinarySearchTreeNode(9, new BinarySearchTreeNode(6), new BinarySearchTreeNode(11, null,
                    new BinarySearchTreeNode(99, new BinarySearchTreeNode(99), null))));

            Assert.AreEqual(BinarySearchTreeNode.minimum(t).Value, 1);
        }

        [TestMethod]
        public void MinEqualsTest () {
            // Test with two equal nodes corresponding to the same maximum.
            BinarySearchTreeNode t = new BinarySearchTreeNode(5,
                new BinarySearchTreeNode(3, new BinarySearchTreeNode(1,
                    new BinarySearchTreeNode(1), null), new BinarySearchTreeNode(4)),
                new BinarySearchTreeNode(9, new BinarySearchTreeNode(6), new BinarySearchTreeNode(11, null,
                    new BinarySearchTreeNode(99, new BinarySearchTreeNode(99), null))));

            Assert.AreEqual(BinarySearchTreeNode.minimum(t).Value, 1);
        }

        [TestMethod]
        public void ContainsTest () {
            BinarySearchTreeNode t = new BinarySearchTreeNode(5,
                new BinarySearchTreeNode(3, new BinarySearchTreeNode(1,
                    new BinarySearchTreeNode(1), null), new BinarySearchTreeNode(4)),
                new BinarySearchTreeNode(9, new BinarySearchTreeNode(6), new BinarySearchTreeNode(11, null,
                    new BinarySearchTreeNode(99, new BinarySearchTreeNode(99), null))));

            Assert.AreEqual(BinarySearchTreeNode.contains(t, 5), true);
            Assert.AreEqual(BinarySearchTreeNode.contains(t, 1), true);
            Assert.AreEqual(BinarySearchTreeNode.contains(t, 13), false);
        }

        [TestMethod]
        public void ValidTest () {
            BinarySearchTreeNode valid = new BinarySearchTreeNode(5,
                new BinarySearchTreeNode(3, new BinarySearchTreeNode(1,
                    new BinarySearchTreeNode(1), null), new BinarySearchTreeNode(4)),
                new BinarySearchTreeNode(9, new BinarySearchTreeNode(6), new BinarySearchTreeNode(11, null,
                    new BinarySearchTreeNode(99, new BinarySearchTreeNode(99), null))));

            Assert.AreEqual(BinarySearchTreeNode.valid(valid), true);

            BinarySearchTreeNode invalid = new BinarySearchTreeNode(5,
                new BinarySearchTreeNode(3,
                  new BinarySearchTreeNode(9), // 9 cannot be a left child of 3.
                  new BinarySearchTreeNode(4)),
                new BinarySearchTreeNode(9,
                  new BinarySearchTreeNode(6),
                  new BinarySearchTreeNode(11,
                    null,
                    new BinarySearchTreeNode(99))));

            Assert.AreEqual(BinarySearchTreeNode.valid(invalid), false);

            // Right children must be strictly greater than the current node.
            BinarySearchTreeNode invalidSimple = new BinarySearchTreeNode(5, new BinarySearchTreeNode(3), new BinarySearchTreeNode(5));
            Assert.AreEqual(BinarySearchTreeNode.valid(invalidSimple), false);
        }
    }
}
