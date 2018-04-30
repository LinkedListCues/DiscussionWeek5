using System;

namespace DiscussionWeek5
{
    /// <summary>
    /// A bog-standard binary search tree.
    /// Left-hand children are less than or equal to the root.
    /// right-hand children are strictly greater than the root.
    /// Duplicates are allowed.
    /// </summary>
    public class BST
    {
        public readonly int Value;
        public readonly BST Left;
        public readonly BST Right;

        public BST (int value, BST left, BST right) {
            Value = value;
            Left = left;
            Right = right;
        }

        public BST (int value) {
            Value = value;
            Left = Right = null;
        }

        /// <summary>
        /// Returns the minimum node in a BST.
        /// </summary>
        public static BST Minimum (BST root) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the maximum node in a given BST.
        /// </summary>
        public static BST Maximum (BST root) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns whether or not the query is contained within the BST.
        /// </summary>
        public static bool Contains (BST root, int query) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Is the given BST valid? I.e., does it satisfy the binary search tree property?
        /// </summary>
        public static bool Valid (BST root) {
            throw new NotImplementedException();
        }
    }
}
