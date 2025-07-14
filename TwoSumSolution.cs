
using System;
using System.Collections.Generic;

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // Dictionary to store value and its index
        Dictionary<int, int> numMap = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];

            // Check if the complement is already in the map
            if (numMap.ContainsKey(complement)) {
                return new int[] { numMap[complement], i };
            }

            // Store current number and index
            if (!numMap.ContainsKey(nums[i])) {
                numMap[nums[i]] = i;
            }
        }

        // If no solution is found
        throw new ArgumentException("No two sum solution");
    }
}

class Program {
    static void Main() {
        Solution solution = new Solution();

        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        int[] result = solution.TwoSum(nums, target);

        Console.WriteLine($"[{result[0]}, {result[1]})");
    }
}
