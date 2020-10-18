using System;
using System.Dynamic;

namespace SearchInsertPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 3, 6, 5 };
            int target = 5;

            Program obj = new Program();
            int result = obj.SearchInsert(nums, target);

            Console.WriteLine(result);
            Console.ReadKey();
        }

        public int SearchInsert(int[] nums, int target)
        {
            int i;
            for (i = 0; i < nums.Length; i++)
            {
                if (nums[i] < target) { continue; }
                else if (nums[i] >= target) { return i; }
            }

            return i;
        }
    }
}
