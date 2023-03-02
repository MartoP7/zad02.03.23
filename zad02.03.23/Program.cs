using System;
using System.Collections.Generic;
using System.Linq;

namespace zad02._03._23
{
    internal class Program
    {
        static void Main()
        {
            // list
            List<int> nums = ListInput();

            // elements count
            ElementsCount(nums);

            // arr1 input
            int[] arr1 = Arr1Input();

            // execute 1
            Execute1(nums, arr1);

            // n input
            byte n = NumInput();

            // if contains N
            IfContainsN(nums, n);

            // arr2 input
            int[] arr2 = Arr2Input();

            // execute 2
            Execute2(nums, arr2);

        }
        private static void Execute2(List<int> nums, int[] arr2)
        {
            // insert from index 3
            nums.InsertRange(3, arr2);
            // sort
            nums.Sort();

            // print list
            Console.WriteLine(string.Join("*", nums));
        }
        private static void Execute1(List<int> nums, int[] arr1)
        {
            // add arr to list
            nums.AddRange(arr1);
            // sort
            nums.Sort();
            // print list
            Console.WriteLine(string.Join(", ", nums));
        }
        private static int[] Arr2Input()
        {
            // second arr
            Console.Write("Въведи arr2 elements: ");
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            return arr2;
        }
        private static void IfContainsN(List<int> nums, byte n)
        {
            //check if contains n
            if (nums.Contains(n))
            {
                Console.WriteLine($"Index of {n} = {nums.IndexOf(n)}");
            }
            else
            {
                Console.WriteLine($"Не съдържа {n}!");
            }
        }
        private static byte NumInput()
        {
            // num input
            Console.Write("Въведи число N: ");
            byte n = byte.Parse(Console.ReadLine());
            return n;
        }
        private static List<int> ListInput()
        {
            // list input
            Console.Write("Въведи list elements: ");
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            return nums;
        }
        private static int[] Arr1Input()
        {
            // arr input
            Console.Write("Въведи arr1 elements: ");
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            return arr1;
        }
        private static void ElementsCount(List<int> nums)
        {
            // elements count
            Console.WriteLine($"Брой на елементите: {nums.Count}");
        }
    }
}
