namespace ChallengeLab_6_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Challenge Labs 6.1");
            Console.WriteLine("LEETCODE #136");
            Console.WriteLine("================\n");

            int[] nums = { 2, 2, 1 };
            int[] nums2 = { 4, 1, 2, 1, 2 };
            int[] nums3 = { 1 };

            Console.WriteLine($"Output for {{2, 2, 1}}: {FindNonDuplicateNumber(nums)}");
            Console.WriteLine($"Output for {{4, 1, 2, 1, 2}}: {FindNonDuplicateNumber(nums2)}");
            Console.WriteLine($"Output for {{1}}: {FindNonDuplicateNumber(nums3)}");

            Console.WriteLine("\n\nChallenge Labs 6.2");
            Console.WriteLine("LEETCODE #268");
            Console.WriteLine("================\n");

            int[] nums4 = { 3, 0, 1 };
            int[] nums5 = { 0, 1 };
            int[] nums6 = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };

            Console.WriteLine($"Output for {{3, 0, 1}}: {FindMissingNumber(nums4)}");
            Console.WriteLine($"Output for {{0, 1}}: {FindMissingNumber(nums5)}");
            Console.WriteLine($"Output for {{9, 6, 4, 2, 3, 5, 7, 0, 1}}: {FindMissingNumber(nums6)}");

            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();
        }

        public static int FindNonDuplicateNumber(int[] nums)
        {
            Dictionary<int, int> numCount = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                if (numCount.ContainsKey(num))
                {
                    numCount[num]++;
                }
                else
                {
                    numCount.Add(num, 1);
                }
            }

            foreach (var kvp in numCount)
            {
                if (kvp.Value == 1)
                {
                    return (kvp.Key);
                }

            }
            throw new InvalidOperationException("No single number found");
        }

        public static int FindMissingNumber(int[] nums)
        {
            Dictionary<int, bool> numSet = new Dictionary<int, bool>();
            int n = nums.Length;

            // Add all numbers from arr to dictionary
            foreach (int num in nums)
            {
                numSet[num] = true;
            }

            // Check missing number from 0 -> n
            for (int i = 0; i <= n; i++)
            {
                if (!numSet.ContainsKey(i))
                {
                    return i;
                }
            }

            throw new InvalidOperationException("No missing number found");
        }
    }
}
