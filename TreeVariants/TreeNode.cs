using System;
using System.Collections.Generic;
using System.Text;

namespace TreeVariants
{
    public class TreeNode<T>
    {
        public T Data { get; set; }
        public TreeNode<T> Parent { get; set; }
        public List<TreeNode<T>> Children {get; set;}

        /// <summary>
        /// Calculates the distance to the root noe
        /// </summary>
        /// <returns>The height of the current node.</returns>
        public int GetHeight()
        {
            int height = 1;
            TreeNode<T> current = this;
            while(current.Parent != null)
            {
                height++;
                current.Parent = Parent;
            }

            return height;
        }
    }
}
