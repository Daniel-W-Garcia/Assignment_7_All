using Assignment_7._3._1;

/*
1. Listen (and ask questions),
2. Generate Examples (that cover all pertinent cases and corner cases),
3. Brute Force (pseudo),
4. Optimize,
5. Walk Through,
6. Test,
7. Implement (code),
8. Test Again

Given the Root of a Binary Tree and an int value, return the node with the given value and it's subtree rooted at that node.
If the value is not found, return null.

Are we returning only the node with a max of 2 children? 
Or are we returning the node and all of it's subtrees?
Are we dealing with natural numbers only?
How do we handle the display of the tree?
For this assignment we will have to create the tree first IOT search it.

example: Root = 1, value = 1, return 1
example: Root = 1, value = 2, return null
example: Root = 1, Root2 = 3, value = 3, return Root 2 and it's subtree
example: val = -n return null

Node Class 
{
    TreeNode Left {get; set;}
    TreeNode Right {get; set;}
    int Value {get; set;}
    Constructor (value, Left, Right)
}

BST Class
{
    Node root
    Constructor root = null
    
    Func AddNode (value)
    {
        NewNode(value)
    
        if there's no root then NewNode is the root
        if not then add the node to the tree
        
        Node currentNode = root - start at the root
        
        drop down through the tree until you find the right spot
        while(true)
        {
            if(value at the inspected node is greater than the value of the current node)
                if(currentNode.Left == null)
                {
                    currentNode.Left = NewNode(value) this is where we assign the new node's value
                    break;
                }
            }
            if(value at the inspected node is less than the value of the current node)
            {
                if(currentNode.Right == null)
                {
                    currentNode.Right = NewNode(value) this is where we assign the new node's value
                    break;
                }
            }
            if the value equals a value in a  then return out because we can't add a duplicate node
            
    Func Search (value)
     {
         current node = root
          while loop to drop through node tree until you find the value
          if the value is found return the node
          if the value is not found return null
                While currentNode != null
                {
                    if(currentNode.Value == value)
                    {
                        return currentNode;
                    }
                    else if(currentNode.Value > value) drop down the tree
                    {
                        currentNode = currentNode.Left;
                    }
                    else if(currentNode.Value < value) drop down the tree the other way
                    {
                        currentNode = currentNode.Right;
                    }
                }
                
     }
     Func MakeTree()
     {
        BST newTree = new BST();
         tree.AddNodes(n);         
     }
     Func DisplayTree()
     {
        CW(newTree.Search(n);)
     } 
}
*/

var randomNumbers = await QuantumRandomGenerator.GetQuantumRandomNumbersAsync(10, "uint8");
BinarySearchTree tree = new BinarySearchTree();

Console.WriteLine();
Console.WriteLine("Are you feeling lucky?\nThink you can guess a quantum random number?\nWe'll make it easier for you.\nWe'll keep it between 0-255\n");
Console.Write("Pick a number between 0-255 as your guess: ");
int searchValue = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Here are the RNG numbers:");
Console.WriteLine();
Node searchedNode = tree.Search(searchValue);

foreach (var num in randomNumbers)
{
    tree.AddNode(num);
    Console.WriteLine(num);
    
}
Console.WriteLine();


if (searchedNode != null)
{
    Console.WriteLine($"Found: {searchedNode.Value}");
}
else
{
    Console.WriteLine($"Sorry your number: '{searchValue}' was not not found\n");
}