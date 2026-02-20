using Visitors;

namespace Domain.AstNodes;

// The bass class for every abstract syntax tree (AST) node
public abstract class AstNode
{
    public abstract void Accept(IAstVisitor visitor);
}
