using System;
using System.Collections;
using System.Collections.Generic;

namespace HelloApp
{
    class Program1
    {
        delegate List<T> Operation<T>(BinaryTree<T> tree);
        static List<T> Func<T>(BinaryTree<T> Tree)
        {
            Operation<T> operation = (BinaryTree<T> tree) =>
            {
                List<T> values = new List<T>();
                foreach (T value in tree)
                    values.Add(value);
                return values;
            };
            return operation(Tree);
        }
    }
}