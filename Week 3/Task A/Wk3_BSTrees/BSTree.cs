using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Wk3_BSTrees
{
    class BSTree<T> : BinTree<T> where T : IComparable
    {
        public BSTree()
        {
            root = null;
        }

        public void InsertItem(T item)
        {
            insertItem(item, ref root);
        }
        private void insertItem(T item, ref Node<T> tree)
        {
            if (tree == null)
            {
                tree = new Node<T>(item);
            }
            else if (item.CompareTo(tree.Data) < 0)
            {
                insertItem(item, ref tree.Left );
            }
            else if (item.CompareTo(tree.Data) > 0)
                insertItem(item, ref tree.Right);
        }
        private T leastItem(Node<T> tree)
        {
            if (tree.Left == null)
                return tree.Data;
            else
                return leastItem(tree.Left);
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
        }
        public int Height()
        //Return the max level of the tree
        {
            return height(root);
        }
        protected int height(Node<T> tree)
        {
            if (tree == null)
                return 0;
            return 1 + Math.Max(height(tree.Left), height(tree.Right));

        }
        private Boolean contains(T item, ref Node<T> tree)
        {
            if (tree == null)
            {
                return false;
            }
            else if (item.CompareTo(tree.Data) < 0)
            {
                if (item.CompareTo(tree.Left) == 0)
                {
                    return true;
                }
                //else { return false; }
            }
            else if (item.CompareTo(tree.Data) > 0)
            {
                if (item.CompareTo(tree.Right) == 0)
                {
                    return true;
                }
                else { return false; }
            }
            return false;
        }
        public Boolean Contains(T item)
        {
            return contains(item, ref root);

        }
       


    }
}
