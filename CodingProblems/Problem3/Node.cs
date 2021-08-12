namespace CodingProblems.Problem3
{
    public class Node
    {
        public Node(string value, Node left, Node right)
        {
            Value = value;
            Left = left;
            Right = right;
        }

        public string Value { get; }
        public Node Left { get; }
        public Node Right { get; }
    }
}