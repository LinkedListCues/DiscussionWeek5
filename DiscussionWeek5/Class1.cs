using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscussionWeek5
{
    public class BinarySearchTreeNode
    {
        public readonly int Value;
        public readonly BinarySearchTreeNode Left;
        public readonly BinarySearchTreeNode Right;

        public BinarySearchTreeNode (int value, BinarySearchTreeNode left, BinarySearchTreeNode right) {
            Value = value;
            Left = left;
            Right = right;
        }

        public BinarySearchTreeNode (int value) {
            Value = value;
            Left = Right = null;
        }

        // Returns the minimum value in the given non-empty binary search tree.
        public static BinarySearchTreeNode minimum (BinarySearchTreeNode root) {
            if (root.Left == null) {
                return root;
            }
            return minimum(root.Left);
        }

        // Returns the maximum value in the given non-empty binary search tree.
        public static BinarySearchTreeNode maximum (BinarySearchTreeNode root) {
            if (root.Right == null) {
                return root;}
            return maximum(root.Right);
        }

        // Returns true or false, depending on whether the given BST contains the
        // specified value.
        public static bool contains (BinarySearchTreeNode root, int query) {
            if (root.Value == query) {
                return true;
            } else if (root.Value > query) {
                return root.Left != null && contains(root.Left, query);
            } else {
                return root.Right != null && contains(root.Right, query);
            }
        }

        // Checks whether a BST is a valid binary search tree.
        public static bool valid (BinarySearchTreeNode root) {
            if (root.Left != null) {
                if (root.Left.Value > root.Value || !valid(root.Left)) {
                    return false;
                }
            }

            if (root.Right != null) {
                if (root.Right.Value <= root.Value || !valid(root.Right)) {
                    return false;
                }
            }

            return true;
        }
    }
}
