using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPlayground.Problems
{
    //problem 1 in hacker rank
    public class Two
    {
        public Two()
        {

        }

        public static int solutionFound = 0;

        public void Execute(string name)
        {
            var arr1 = new List<int> { 18, 11, 21, 28, 31, 38, 40, 55, 60, 62 };
            var arr2 = new List<int> { 11, 18, 21, 28, 31, 38, 40, 55, 60, 62 };

            var arr1Sum = 66;
            var arr2Sum = 67;

            Console.WriteLine("Solutions...");

            sum_up(arr1, arr1Sum);
            Console.WriteLine($"Solution found? {solutionFound}");

            solutionFound = 0;

            sum_up(arr2, arr2Sum);
            Console.WriteLine($"Solution found? {solutionFound}");

        }

        public void sum_up(List<int> arr, int target)
        {
            recursionSum(arr, target, new List<int>());
        }

        public static void recursionSum(List<int> values, int target, List<int> unUsedValues)
        {
            var sum = 0;

            foreach (var x in unUsedValues)
                sum += x;

            if (sum == target && unUsedValues.Count == 2)
                solutionFound = 1;

            if (sum >= target)
                return;

            for (int i = 0; i < values.Count; i++)
            {
                var remaining = new List<int>();
                int n = values[i];
                for (int j = i + 1; j < values.Count; j++)
                {
                    remaining.Add(values[j]);
                }
                var part_rec = new List<int>(unUsedValues);
                part_rec.Add(n);
                recursionSum(remaining, target, part_rec);
            }

        }
    }


}
