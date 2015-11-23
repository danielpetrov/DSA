namespace Trees
{
    using System;
    using System.Collections.Generic;

    public class Tree<T>
    {
        private TreeNode<T> root;

        private long sum;
        public Tree(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(
                    "Cannot insert null value!");
            }

            this.Root = new TreeNode<T>(value);
        }

        public Tree(T value, params Tree<T>[] children) : this(value)
        {
            foreach (Tree<T> child in children)
            {
                this.root.AddChild(child.root);
            }
        }

        /// <summary>
        /// The root node or null if the tree is empty
        /// </summary>
        public TreeNode<T> Root
        {
            get
            {
                return this.root;
            }
            private set
            {
                this.root = value;
            }
        }

        public void GetAllRoots()
        {
            this.GetAllRoots(this.root);
        }
        private void GetAllRoots(TreeNode<T> root)
        {
            if (root.ChildrenCount == 0)
            {
                Console.WriteLine(root.Value);
                return; 
            }

            TreeNode<T> child = null;

            //if (root.hasParent && root.ChildrenCount != 0)// - root.hasOarent for all leafs
            //{
            //    Console.WriteLine(root.Value);
            //}

            for (int i = 0; i < root.ChildrenCount; i++)
            {
                child = root.GetChild(i);
                this.GetAllRoots(child);
             }
        }

        public void AllPathsWithGivenSum(long sum)
        {
            this.sum = sum;
            this.AllPathsWithGivenSum(this.root, 0);
        }
        private void AllPathsWithGivenSum(TreeNode<T> root, long currentSum)
        {
            if (root == null)
            {
                return;
            } 
            else
            {
                currentSum += Int64.Parse(root.Value.ToString());
            }

            if (root.ChildrenCount == 0)
            {
                if(currentSum == this.sum)
                { 
                    Console.WriteLine(currentSum);
                }
            }
            
            for (int i = 0; i < root.ChildrenCount; i++)
            {
                this.AllPathsWithGivenSum(root.GetChild(i), currentSum);
                //currentSum -= Int64.Parse(root.Value.ToString());
            }
        }

        private void TraverseDFS(TreeNode<T> root, string spaces)
        {
            if (root == null)
            {
               return;
            }

            Console.WriteLine(spaces + root.Value);

            TreeNode<T> child = null;

            for (int i = 0; i < root.ChildrenCount; i++)
            {
                child = root.GetChild(i);
                this.TraverseDFS(child, spaces + "   ");
            }
        }

        public void TraverseDFS()
        {
            this.TraverseDFS(this.root, string.Empty);
        }

        public void TraverseBFS()
        {
            Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();
            queue.Enqueue(this.root);
            while (queue.Count > 0)
            {
                TreeNode<T> currentNode = queue.Dequeue();
                Console.Write("{0} ", currentNode.Value);
                for (int i = 0; i < currentNode.ChildrenCount; i++)
                {
                    TreeNode<T> childNode = currentNode.GetChild(i);
                    queue.Enqueue(childNode);
                }
            }
        }

        public void TraverseDFSWithStack()
        {
            Stack<TreeNode<T>> stack = new Stack<TreeNode<T>>();
            stack.Push(this.root);
            while (stack.Count > 0)
            {
                TreeNode<T> currentNode = stack.Pop();
                Console.Write("{0} ", currentNode.Value);
                for (int i = 0; i < currentNode.ChildrenCount; i++)
                {
                    TreeNode<T> childNode = currentNode.GetChild(i);
                    stack.Push(childNode);
                }
            }
        }
    }
}
