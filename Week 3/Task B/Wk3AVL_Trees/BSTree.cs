using System;
using System.Collections.Generic;
using System.Text;

namespace Wk3AVL_Trees
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
                tree = new Node<T>(item);
            //stopping condition
            //recursive calls - decide: go left, go right,
            else if (item.CompareTo(tree.Data) < 0)
                insertItem(item, ref tree.Left);
            else if (item.CompareTo(tree.Data) > 0)
                insertItem(item, ref tree.Right);
            else { } // if they are the same
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
        public bool Equals(BSTree<T> tree)
        {
            // tree.Data;
            //bstree object == tree

            //input 


            //returns true if this BSTree object contains all the same data as
            //tree with the same structure and ordering of data.


            //return (this.PreOrder() == tree.PreOrder() && this.InOrder() == tree.InOrder() && this.PostOrder() == tree.PostOrder());


            return false;
        }
        public bool SubTree(BSTree<T> tree)
        {
            return false;
        }
        


    }
}
