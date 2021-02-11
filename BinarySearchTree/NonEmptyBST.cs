using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinarySearchTree
{
    public class NonEmptyBST<T> : Tree<T> where T : IComparable
    {
        T data;
        Tree<T> left;
        Tree<T> right;

        public NonEmptyBST(T elt)
        {
            data = elt;
            left = new EmptyBST<T>();
            right = new EmptyBST<T>();
        }

        public NonEmptyBST(T elt, Tree<T> leftTree, Tree<T> rightTree) 
        {
            data = elt;
            left = leftTree;
            right = rightTree;
        }

        public bool isEmpty()
        {
            return false;
        }

        public int cardinality()
        {
            return 1 + left.cardinality() + right.cardinality();
        }

        public bool member(T elt)
        {
            if (elt.CompareTo(data) == 0)
            {
                return true;
            }
            else
            {
                if (elt.CompareTo(data) < 0)
                {
                    return left.member(elt);
                }
                else
                {
                    return right.member(elt);
                }
            }
        }

        public NonEmptyBST<T> add(T elt)
        {
            if (elt.CompareTo(data) == 0)
            {
                return this;
            }
            else
            {
                if (elt.CompareTo(data) < 0) {
                    return new NonEmptyBST<T>(data, left.add(elt), right);
                } else {
                    return new NonEmptyBST<T>(data, left, right.add(elt));                
                }
            }
        }

    }
}
