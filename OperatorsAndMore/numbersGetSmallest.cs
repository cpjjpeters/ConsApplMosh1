using System;
using System.Collections.Generic;

namespace OperatorsAndMore
{
    class numbersGetSmallest
    {
        public static List<int> getSmallest(List<int> list, int count)
        {
            var smallest = new List<int>();
            while (smallest.Count < count)
            {
                var min = getSmallest(list);
                smallest.Add(min);
                list.Remove(min);
            }
            return smallest;
        }

        public static int getSmallest(List<int> list)
        {
            var min = list[0];
            for (var i = 1; i < list.Count; i++)
            {
                if (list[i] > min)
                    min = list[i];
            }
            return min;

        }

        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            var lijst = new List<int> { 1, 2, 3, 4, 5, 6 };
            var smallest = getSmallest(numbers, 3);
            foreach (var number in smallest)
            {
                Console.WriteLine(number);
            }

        }
    }
}
