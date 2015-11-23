namespace TreesAndTraversalsHomerwork
{
    using System;
    using Trees;

    public static class TreeExample
    {
        static void Main()
        {
            Tree<int> tree =
            new Tree<int>(7,
                          new Tree<int>(19,
                                        new Tree<int>(1),
                                        new Tree<int>(12),
                                        new Tree<int>(31)),
                          new Tree<int>(21),
                          new Tree<int>(14,
                                        new Tree<int>(23),
                                        new Tree<int>(6)));

            //Console.WriteLine(tree.Root.Value);

            tree.AllPathsWithGivenSum(28);
            //Console.WriteLine("Depth-First Search (DFS) traversal (recursive):");
           // tree.TraverseDFS();

        }
    }
}
