class BinarySearchTree
{
    private Node _root;
    
    public BinarySearchTree()
    {
        _root = null;
    }

    public void AddNode(int value)
    {
        Node newNode = new Node(value);
        
        if(_root == null)
        {
            _root = newNode;
            return;
        }

        Node currentNode = _root;
        
        while (true)
        {
            if (value < currentNode.Value)
            {
                if (currentNode.TreeNodeLeft == null)
                {
                    currentNode.TreeNodeLeft = newNode;
                    break;
                }
                currentNode = currentNode.TreeNodeLeft;
            }

            else if (value > currentNode.Value)
            {
                if (currentNode.TreeNodeRight == null)
                {
                    currentNode.TreeNodeRight = newNode;
                    break;
                }
                currentNode = currentNode.TreeNodeRight;
            }
            else
            {
                return;
            }
        }
    }
    public Node Search(int value) 
    {
        Node currentNode = _root;

        while (currentNode != null)
        {
            if (currentNode.Value == value)
            {
                return currentNode;
            }
            else if (value < currentNode.Value)
            {
                currentNode = currentNode.TreeNodeLeft;
            }
            else 
            {
                currentNode = currentNode.TreeNodeRight;
            }
        }
        return null;  // Return null if not found
    }
    public void PrintSubtree(Node node)
    {
        if (node == null) return;
    
        Console.WriteLine($"Node: {node.Value}");
    
        if (node.TreeNodeLeft != null)
            Console.WriteLine($"Left Child: {node.TreeNodeLeft.Value}");
    
        if (node.TreeNodeRight != null)
            Console.WriteLine($"Right Child: {node.TreeNodeRight.Value}");
    
        PrintSubtree(node.TreeNodeLeft);
        PrintSubtree(node.TreeNodeRight);
    }
}