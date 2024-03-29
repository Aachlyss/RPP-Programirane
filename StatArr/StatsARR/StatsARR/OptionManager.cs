﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatsARR
{
    public static class OptionManager
    {
        public static int CountLess100(int[]arr)
        {
            return arr.Count(x => x < 100);
        }
        public static int Max(int[] arr)
        {
            return arr.Max();
        }
        public static int[] ReverseArr(int[] arr)
        {
            return arr.Reverse().ToArray();
        }
        public static void OddNums(int[] arr)
        {
            var result = arr.Where(x => x % 2 == 0).ToArray();
            Console.WriteLine(string.Join(", ",result));
        }
        public static void OddSum(int[] arr)
        {
            var result = arr.Where(x => x % 2 == 0).Sum();
            Console.WriteLine(string.Join(", ", result));
        }
        public static void OddCount(int[] arr)
        {
            var result = arr.Where(x => x % 2 == 0).Count();
            Console.WriteLine(string.Join(", ", result));
        }
        public static void PrintArr(int[] arr)
        {
            Console.WriteLine(string.Join(", ",arr));    
        }

    }
}
