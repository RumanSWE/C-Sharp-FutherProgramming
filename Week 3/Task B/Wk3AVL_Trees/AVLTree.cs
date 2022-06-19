using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Wk3AVL_Trees
{
    class AVLTree<T> : BSTree<T> where T : IComparable
    {
        public AVLTree()
        {
            root = null;
        }
        public void InsertItem(T item)
        {
            insertItem(item, ref root);
        }



        private void insertItem(T item , ref Node<T> tree)
        {
            if (tree == null)
            {
                tree = new Node<T>(item);
            }
            else if (item.CompareTo(tree.Data) < 0)
            {
                insertItem(item, ref tree.Left);
            }
            else if (item.CompareTo(tree.Data) > 0)
                insertItem(item, ref tree.Right);
            else
            {

            }

            tree.BalanceFactor = height(tree.Left) - height(tree.Right);

            if (tree.BalanceFactor <= -2)
            {
                rotateLeft(ref tree);
            }
            if (tree.BalanceFactor >= 2)
            {
                rotateRight(ref tree);
            }
        }
        
        public void removeItem(T item, ref Node<T> tree)
        {
            if (tree == null)
            {

            }
            if (item.CompareTo(tree.Data) < 0)
                removeItem(item, ref tree.Left);
            else if (item.CompareTo(tree.Data) < 0)
                removeItem(item, ref tree.Right);
            //reapeat for right

            if (tree.Left == null)
                tree = tree.Right;
            //reapet for right
            T newRoot = leastItem(tree.Right);
            tree.Data = newRoot;
            removeItem(newRoot, ref tree.Right);

            tree.BalanceFactor = height(tree.Left) - height(tree.Right);

            if (tree.BalanceFactor <= -2)
            {
                rotateLeft(ref tree);
            }
            if (tree.BalanceFactor >= 2)
            {
                rotateRight(ref tree);
            }
        }
        private T leastItem(Node<T> tree)
        {
            if (tree.Left == null)
                return tree.Data;
            else
                return leastItem(tree.Left);
        }
        
        private void rotateLeft(ref Node<T> tree)
        {
            if (tree.Right.BalanceFactor > 0)// double rotate
            {
                rotateRight(ref tree.Right);
            }
                
            Node<T> newRoot, oldRoot;

            oldRoot = tree;
            newRoot = oldRoot.Right;
            oldRoot.Right = newRoot.Left;
            newRoot.Left = oldRoot;
            tree = newRoot;

            
        }
        private void rotateRight(ref Node<T> tree)
        {
            if (tree.Left.BalanceFactor < 0)// double rotate
            {
                rotateLeft(ref tree.Left);
            }
            Node<T> newRoot, oldRoot;

            oldRoot = tree;
            newRoot = oldRoot.Left;
            oldRoot.Left = newRoot.Right;
            newRoot.Right = oldRoot;
            tree = newRoot;

        }
        
        
    }
}
