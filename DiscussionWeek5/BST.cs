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
            while (true) {
                if (root.Left == null) { return root; }
                root = root.Left;
            }
        }

        /// <summary>
        /// Returns the maximum node in a given BST.
        /// </summary>
        public static BST Maximum (BST root) {
            while (true) {
                if (root.Right == null) { return root; }
                root = root.Right;
            }
        }

        /// <summary>
        /// Returns whether or not the query is contained within the BST.
        /// </summary>
        public static bool Contains (BST root, int query) {
            if (root.Value == query) { return true; }

            if (root.Value > query) {
                return root.Left != null && Contains(root.Left, query);
            }

            return root.Right != null && Contains(root.Right, query);
        }

        /// <summary>
        /// Is the given BST valid? I.e., does it satisfy the binary search tree property?
        /// </summary>
        public static bool Valid (BST root) {
            if (root.Left != null
                && (root.Left.Value > root.Value || !Valid(root.Left))) {
                return false;
            }

            if (root.Right == null) { return true; }
            return root.Right.Value > root.Value && Valid(root.Right);
        }
    }
}
