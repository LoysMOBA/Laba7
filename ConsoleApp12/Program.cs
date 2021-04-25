using System;
using System.Collections;
using System.Collections.Generic;

namespace HelloApp
{
    class Program
    {
        delegate T Builder<out T>(BinaryTree<int> integetTree);
        static void Main(string[] args)
        {
            BinaryTree<int> integerTree = new BinaryTree<int>();
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                int value = rand.Next(100);
                Console.WriteLine("Adding {0}", value);
                integerTree.Add(value);
            }

            Console.WriteLine("Number of nodes is {0}", integerTree.Count);
            Console.WriteLine("Обход в ширину:");
            Console.WriteLine(string.Join(" ", integerTree.Preorder()));
            Console.WriteLine("Симметричный обход:");
            Console.WriteLine(string.Join(" ", integerTree.Inorder()));
            Console.WriteLine("обход в глубину:");
            Console.WriteLine(string.Join(" ", integerTree.Postorder()));
            Console.WriteLine("обход по уровням:");
            Console.WriteLine(string.Join(" ", integerTree.Levelorder()));
            Console.WriteLine("Обход по умолчанию (в порядке):");
            foreach (int n in integerTree)
                Console.Write("{0} ", n);
            Console.WriteLine();
            Console.ReadKey(true);
        }
    }
}
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Library numbers = new Library();
//            foreach (Book books in numbers)
//            {
//                Console.WriteLine();
//            }
//            Console.ReadKey();
//        }
//    }

//    class Book
//    {
//        public Book(string name)
//        {
//            this.Name = name;
//        }
//        public string Name { get; set; }
//    }

//    class Library
//    {
//        private Book[] books;

//        public Library()
//        {
//            books = new Book[] { new Book("Отцы и дети"), new Book("Война и мир"),
//                new Book("Евгений Онегин") };
//        }

//        public int Length
//        {
//            get { return books.Length; }
//        }

//        public IEnumerator GetEnumerator()
//        {
//            for (int i = 0; i < books.Length; i++)
//            {
//                yield return books[i];
//            }
//        }
//    }
//}