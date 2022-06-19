using System;
using System.Collections.Generic;
using System.Text;

namespace Wk3AVL_Trees
{
    class BinTree<T> where T : IComparable
    {
        protected Node<T> root; //change to protected //top of tree

        public BinTree()  //creates an empty tree
        {
            root = null;
        }
        public BinTree(Node<T> node)  //creates a tree with node as the root
        {
            root = node; 
                         
        }
        public int Height(Node<T> tree)
        //Return the max level of the tree
        {
            return height(tree);
        }
        protected int height(Node<T> tree)
        {
            if (tree == null)
                return 0;

            int left = height(tree.Left);
            int right = height(tree.Right);

            if (left > right)
                return left + 1;
            else
                return right + 1;

        }
        public string PreOrder()
        {
           return preOrder(root, null);
        }
       
        private string preOrder(Node<T> tree, string buffer)
        {

            if (tree != null)
            { return buffer; }
            else
            {
                buffer += tree.Data.ToString() + ", ";
                preOrder(tree.Left,  buffer);
                preOrder(tree.Right, buffer);
                return buffer;
            }

        }
        
        public void PostOrder(ref string buffer)
        {
            postOrder(root, ref buffer);
        }
        private void postOrder(Node<T> tree, ref string buffer)
        {

            if (tree != null)
            {

                postOrder(tree.Left, ref buffer);
                postOrder(tree.Right, ref buffer);
                buffer += tree.Data.ToString() + ",";
            }

        }
        public void InOrder(ref string buffer)
        {
            inOrder(root, ref buffer);
        }

        private void inOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                inOrder(tree.Left, ref buffer);
                buffer += tree.Data.ToString() + ",";
                inOrder(tree.Right, ref buffer);
            }
        }
        
        public int Count()
        {
            return count(root);
        }
        private int count(Node<T> tree)
        {
            if (tree == null)

                return 0;
            return 1 + count(tree.Left) + count(tree.Right);
        }
        
        public void CopyTo(BinTree<T> tree)
        {
            copyTo(this.root, ref tree.root);
        }
        private void copyTo(Node<T> copiedFromNode, ref Node<T> copiedToNode)
        {
            if (copiedFromNode == null)
                copiedToNode = null;
            else
            {
                copiedToNode = new Node<T>(copiedFromNode.Data); //process node 
                copyTo(copiedFromNode.Left, ref copiedToNode.Left); //copy left subtree
                copyTo(copiedFromNode.Right, ref copiedToNode.Right); //copy right subtree
            }
        }
        

    }

}

