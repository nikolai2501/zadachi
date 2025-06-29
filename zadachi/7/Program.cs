﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 =int.Parse(Console.ReadLine());
            int num2 =int.Parse(Console.ReadLine());

            IEnumerable<IEnumerable<int>> result =
    GetPermutations(Enumerable.Range(num1,num2),2);

        }
        static IEnumerable<IEnumerable<T>>
    GetPermutations<T>(IEnumerable<T> list, int length)
        {
            if (length == 1) return list.Select(t => new T[] { t });

            return GetPermutations(list, length - 1)
                .SelectMany(t => list.Where(e => !t.Contains(e)),
                    (t1, t2) => t1.Concat(new T[] { t2 }));
        }
    }
}
