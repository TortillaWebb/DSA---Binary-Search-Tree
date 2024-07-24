using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AssessedExercise2
{
    class BinTree
    {
        private Node root;

        public BinTree() 
        {		      

            root = null;
        }
        public BinTree(Node root) 
        {
            this.root = root;
        }

        public string PreOrder()
        {
            StringBuilder sb = new StringBuilder();
            preOrder(root, sb);
            return sb.ToString();
        }

        public void preOrder(Node tree, StringBuilder sb)
        {
            if (tree != null)
            {
                sb.Append(tree.Data + ",");
                preOrder(tree.Left, sb);
                preOrder(tree.Right, sb);
               
            }
        }

        public string InOrder()  
        {
            StringBuilder sb = new StringBuilder();
            inOrder(root, sb);
            return sb.ToString();
        }

        private void inOrder(Node tree, StringBuilder sb)
        {
            if (tree != null) 
            {
                inOrder(tree.Left, sb);
                sb.Append(tree.Data + ",");
                inOrder(tree.Right, sb);
            }
        }

        public string PostOrder()
        {
            StringBuilder sb = new StringBuilder();
            postOrder(root, sb);
            return sb.ToString();

        }

        public void postOrder(Node tree, StringBuilder sb)
        {
            if (tree != null)
            {
                postOrder(tree.Left, sb);
                postOrder(tree.Right, sb);
                sb.Append(tree.Data + ",");
            }
        }

        public int height()
        {
            return height(root);
        }

        private int height(Node tree)
        {
            if (tree == null)
            {
                return 0;
            }
            else
            {
                return 1 + Math.Max(height(tree.Left), height(tree.Right));
            }

        }

        public int Count()
        {
            return count(root);
        }

        private int count(Node tree)
        {
            if (tree == null)
            {
                return 0;
            }

            return count(tree.Left) + count(tree.Right) + 1;
        }

        public void InsertItem(int item)
        {
            insertItem(item, ref root);
        }

        private void insertItem(int item, ref Node tree)
        {
            if (tree == null)
                tree = new Node(item);

            else if (item < tree.Data)
                insertItem(item, ref tree.Left);

            else if (item > tree.Data)
                insertItem(item, ref tree.Right);

        }

       


    }

}