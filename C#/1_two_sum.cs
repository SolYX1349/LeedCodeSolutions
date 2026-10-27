/*
You are given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.

 
Example 1:

Input: nums = [2,7,11,15], target = 9

Output: [0,1]

Explanation:

The sum of nums[0] and nums[1] is 2 + 7 = 9, which equals the target. Therefore, the indices [0, 1] are returned.

Example 2:

Input: nums = [3,2,4], target = 6

Output: [1,2]

Explanation:

The sum of nums[1] and nums[2] is 2 + 4 = 6, which equals the target. Therefore, the indices [1, 2] are returned.

Example 3:

Input: nums = [3,3], target = 6

Output: [0,1]

Explanation:

The sum of nums[0] and nums[1] is 3 + 3 = 6, which equals the target. Therefore, the indices [0, 1] are returned.
*/

public class Solution
{
    public static void Main()
    {
        test_1();
        test_2();
        test_3();
        test_4();
    }

    public static void test_1()
    {
        int[] nums = new { 2, 7, 11, 15 };
        int[] result = TwoSum(nums, 9);
        Console.WriteLine($"[{result[0]}, {result[1]}]");
        System.Console.WriteLine("Expected: [0,1]");
    }
    public static void test_2()
    {
        int[] nums = new { 3, 2, 4 };
        int[] result = TwoSum(nums, 6);
        Console.WriteLine($"[{result[0]}, {result[1]}]");
        System.Console.WriteLine("Expected: [1,2]");
    }
    public static void test_3()
    {
        int[] nums = new { 3, 3 };
        int[] result = TwoSum(nums, 6);
        Console.WriteLine($"[{result[0]}, {result[1]}]");
        System.Console.WriteLine("Expected: [0,1]");
    }
    public static void test_4()
    {
        int[] nums = new { 2, 5, 5, 11 };
        int[] result = TwoSum(nums, 10);
        Console.WriteLine($"[{result[0]}, {result[1]}]");
        System.Console.WriteLine("Expected: [1,2]");
    }


    public static int[] TwoSum(int[] nums, int target)
    {
        int[] res = { 0, 0 };
        int lg = nums.Length;
        for (int i = 0; i < lg; i++)
        {
            for (int j = 1; j < lg; j++)
            {
                if (i != j && nums[i] + nums[j] == target)
                {
                    res[0] = i;
                    res[1] = j;
                    return res;
                }
            }
        }
        return res;
    }
}