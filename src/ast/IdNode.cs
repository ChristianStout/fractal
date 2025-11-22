using fractal.src.visitors;

namespace fractal.src.ast;

public class IdNode(string Id) : ExprNode
{
    public string id = Id;

    public override void Accept(IVisitor visitor)
    {
        visitor.PreVisitId(this);
        visitor.VisitId(this);
        visitor.PostVisitId(this);
    }
}