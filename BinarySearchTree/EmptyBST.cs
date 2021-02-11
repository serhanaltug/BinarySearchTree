using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class EmptyBST<T> : Tree<T> where T : IComparable
    {
        public EmptyBST()
        {
        }

        public bool isEmpty()
        {
            return true;
        }

        public int cardinality()
        {
            return 0;
        }

        public bool member(T elt)
        {
            return false;
        }

        public NonEmptyBST<T> add(T elt) {
            return new NonEmptyBST<T>(elt);
        }
    
    }
}
