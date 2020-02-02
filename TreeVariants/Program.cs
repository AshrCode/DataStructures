using System;
using System.Collections.Generic;

namespace TreeVariants
{
    class Program
    {
        static void Main(string[] args)
        {
            // General Structure
            Tree<int> tree = new Tree<int>();
            tree.Root = new TreeNode<int>() { Data = 100 };
            tree.Root.Children = new List<TreeNode<int>>
            {
                new TreeNode<int>() { Data = 50, Parent = tree.Root },
                new TreeNode<int>() { Data = 1, Parent = tree.Root },
                new TreeNode<int>() { Data = 30, Parent = tree.Root }
            };
            tree.Root.Children[2].Children = new List<TreeNode<int>>
            {
                new TreeNode<int>() { Data = 30, Parent = tree.Root.Children[2] }
            };



            // A company hierarchy in Tree Structure
            Tree<Person> company = new Tree<Person>();
            company.Root = new TreeNode<Person>()
            {
                Data = new Person(101, "Ibrahim", "CEO"),
                Parent = null
            };
            company.Root.Children = new List<TreeNode<Person>>()
            {
                new TreeNode<Person>()
                {
                    Data = new Person(411, "Jameel Ahmed", "Head of operations"),
                    Parent = company.Root
                },
                new TreeNode<Person>()
                {
                    Data = new Person(415, "Muhammad Saleem", "Head of delivery"),
                    Parent = company.Root
                }
            };
            company.Root.Children[1].Children = new List<TreeNode<Person>>()
            {
                new TreeNode<Person>()
                {
                    Data = new Person(601, "Anusha Shaw", "Program Manager"),
                    //Parent = company.Root.Parent.Children[1] //This won't work here
                }
            };

            company.Root.Children[1].Children[0].Parent = company.Root.Children[1];


            Console.WriteLine("This is how tree structure works like!");

            Console.ReadLine();
        }
    }
}
