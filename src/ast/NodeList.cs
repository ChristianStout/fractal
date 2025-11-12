using fractal.src.visitors;

namespace fractal.src.ast;

public class NodeList : Node
{
    List<Node> innerList { get; set; }

    public NodeList(List<Node> list)
    {
        innerList = list;
    }

    public void Add(Node node)
    {
        innerList.Add(node);
    }
    
    public override void Accept(IVisitor visitor)
    {
        // visitor.Visit(this);
        foreach (Node child in innerList)
        {
            child.Accept(visitor);
        }
    }
}
