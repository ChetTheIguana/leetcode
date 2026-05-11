using System;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] result = new int[2];
        for(var n = 0; n<nums.Length; n++){
            //Console.WriteLine($"{n} = {nums[n]}");
            for(var n2 = 0; n2 < nums.Length; n2++)
            {
                //Console.WriteLine($"{n2} = {nums[n2]}");
                if (nums[n] + nums[n2] == target && n != n2)
                {
                    result[0]=n;
                    result[1]=n2; 
                    
                }
            }
        }
        return result;
        
    }
}

class Program
{
    static void Main()
    {
        var sol = new Solution();

        // Example 1: expected [0, 1]
        int[] result1 = sol.TwoSum([2, 7, 11, 15], 9);
        Console.WriteLine($"Example 1: [{result1[0]}, {result1[1]}]");

        // Example 2: expected [1, 2]
        int[] result2 = sol.TwoSum([3, 2, 4], 6);
        Console.WriteLine($"Example 2: [{result2[0]}, {result2[1]}]");

        // Example 3: expected [0, 1]
        int[] result3 = sol.TwoSum([3, 3], 6);
        Console.WriteLine($"Example 3: [{result3[0]}, {result3[1]}]");
    }
}
