﻿///Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
///You may assume that each input would have exactly one solution, and you may not use the same element twice.
///You can return the answer in any order. <summary>
/// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
/// </summary>
public class Solution1
{
    public int[] TwoSum(int[] nums, int target)
    {

        int[] array = new int[2];

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    array[0] = i;
                    array[1] = j;
                    return array;
                }
            }

        }
        return array;
    }
}