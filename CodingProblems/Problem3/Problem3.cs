using System;
using System.Text;

namespace CodingProblems.Problem3
{
    /// <summary>
    /// This problem was asked by Google.
    /// Given the root to a binary tree, implement serialize(root), which serializes the tree into a string, and deserialize(s), which deserializes the string back into the tree.
    ///
    /// For example, given the following Node class
    /// class Node :
    ///    def __init__(self, val, left=None, right=None):
    ///        self.val = val
    ///        self.left = left
    ///        self.right = right
    /// The following test should pass:
    /// node = Node('root', Node('left', Node('left.left')), Node('right'))
    /// assert deserialize(serialize(node)).left.left.val == 'left.left'
    /// </summary>
    public class Problem3
    {
        public string SerializeTree(Node node)
        {
            var serialized = new StringBuilder();

            serialized.Append(node.Value);

            if (!IsLeaf(node))
                serialized.Append(".");

            if (node.Left != null)
                serialized.Append("Left.").Append(SerializeTree(node.Left));

            if(node.Right != null)
                serialized.Append("Right.").Append(SerializeTree(node.Right));

            return serialized.ToString();
        }

        private bool IsLeaf(Node node)
        {
            return node.Left == null && node.Right == null;
        }

        public Node DeserializeTree(String tree)
        {
            var treeParts = tree.Split('.');

            foreach(var part in treeParts)
            {

            }
        }
    }
}