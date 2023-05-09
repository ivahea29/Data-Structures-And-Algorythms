using System;


//in your own words, define BST balance factor.

    // The BST balance factor is the height of the left subtree minus the height of the right subtree. 
    // Balance Factor = (Height of Left Subtree - Height of Right Subtree) or (Height of Right Subtree - Height of Left Subtree)

//• In your own words, describe the rules of 3 order B-tree.

    // B-Trees are self balancing data structure. The rules to creating them are:
    // 1. Every node in a B-Tree contains at most m children.
    // 2. Every node in a B-Tree except the root node and the leaf node contain at least m/2 children.
    // 3. The root nodes must have at least 2 nodes.
    // 4. All leaf nodes must be at the same level.


//• Insert the numbers 10 12 8 6 5 into an AVL tree.
//o Draw the resulting tree before rebalancing
//o Draw the tree after rebalancing
//o What rotation was performed in rebalancing the tree?


namespace task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}