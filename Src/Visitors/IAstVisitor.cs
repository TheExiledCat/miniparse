using Domain.AstNodes;

namespace Visitors;

public interface IAstVisitor<T>
{
    //add a single visit function for each node type you want to be able to visit
    // each visit optionally returns a node which can be used for editing the tree
    // for most cases this will just be 'return node'
    /*
    example:

    AstNode Visit(BinaryNode node);
    etc...
    */

    public T Visit(AddNode node);
    public T Visit(AssignmentNode node);
    public T Visit(ConstantNode node);
    public T Visit(DivideNode node);
    public T Visit(MultiplyNode node);
    public T Visit(SubtractNode node);
    public T Visit(VariableNode node);
}
