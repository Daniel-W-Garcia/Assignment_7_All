public class Node 
{
    public Node TreeNodeLeft {get; set;}
    public Node TreeNodeRight {get; set;}
    public int Value {get; set;}

    public Node(int value)
    {
        Value = value;
        TreeNodeLeft = null;
        TreeNodeRight = null;
    } 
}