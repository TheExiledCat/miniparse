namespace Visitors;

public interface IAstVisitor
{

    //add a single visit function for each node type you want to be able to visit
    // each visit optionally returns a node which can be used for editing the tree
    // for most cases this will just be 'return node'
    /*
    example:

    AstNode Visit(BinaryNode node);
    etc...
    */
}
