using DiscussionWeek5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BSTTests
{
    [TestClass]
    public class BSTTests
    {
        [TestMethod]
        public void MaxTest () {
            var bst =
                new BST(5,
                    new BST(3, new BST(1), new BST(4)),
                    new BST(9,
                        new BST(6),
                        new BST(11, null, new BST(99))));
            Assert.AreEqual(BST.Maximum(bst).Value, 99);
        }

        [TestMethod]
        public void MaxEqualsTest () {
            var bst =
                new BST(5,
                    new BST(3, new BST(1), new BST(4)),
                    new BST(9,
                        new BST(6),
                        new BST(11,
                            null,
                            new BST(99, new BST(99), null))));

            Assert.AreEqual(BST.Maximum(bst).Value, 99);
        }

        [TestMethod]
        public void MinTest () {
            var bst =
                new BST(5,
                    new BST(3, new BST(1), new BST(4)),
                    new BST(9,
                        new BST(6),
                        new BST(11,
                            null,
                            new BST(99, new BST(99), null))));

            Assert.AreEqual(BST.Minimum(bst).Value, 1);
        }

        [TestMethod]
        public void MinEqualsTest () {
            // Test with two equal nodes corresponding to the same maximum.
            var bst =
                new BST(5,
                    new BST(3,
                        new BST(1, new BST(1), null),
                        new BST(4)),
                    new BST(9,
                        new BST(6),
                        new BST(11,
                            null,
                            new BST(99, new BST(99), null))));

            Assert.AreEqual(BST.Minimum(bst).Value, 1);
        }

        [TestMethod]
        public void ContainsTest () {
            var bst =
                new BST(5,
                    new BST(3,
                        new BST(1, new BST(1), null),
                        new BST(4)),
                    new BST(9,
                        new BST(6),
                        new BST(11,
                            null,
                            new BST(99, new BST(99), null))));

            Assert.IsTrue(BST.Contains(bst, 5));
            Assert.IsTrue(BST.Contains(bst, 1));
            Assert.IsFalse(BST.Contains(bst, 13));
        }

        [TestMethod]
        public void ValidTest () {
            var valid =
                new BST(5,
                    new BST(3,
                        new BST(1, new BST(1), null),
                        new BST(4)),
                    new BST(9,
                        new BST(6),
                        new BST(11,
                            null,
                            new BST(99, new BST(99), null))));

            Assert.IsTrue(BST.Valid(valid));
        }

        [TestMethod]
        public void InvalidTestLeft () {
            var invalid =
                new BST(5,
                    new BST(3, new BST(9), new BST(4)),
                    new BST(9,
                        new BST(6),
                        new BST(11, null, new BST(99))));

            Assert.IsFalse(BST.Valid(invalid));
        }

        [TestMethod]
        public void InvalidTestRight () {
            // Right children must be strictly greater than the current node.
            var invalidSimple = new BST(5, new BST(3), new BST(5));
            Assert.IsFalse(BST.Valid(invalidSimple));
        }
    }
}
