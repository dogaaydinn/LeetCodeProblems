namespace LeetCodeProblems.TwoSum;

using System.Collections.Generic;

public class TwoSum {

    public int[] TwoSumSolution(int[] nums, int target)
    {
        Dictionary<int, int> returnedIndices = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {

            int other = target - nums[i];

            if (returnedIndices.ContainsKey(other))
            {
                return new int[] { returnedIndices[other], i };
            }

            returnedIndices[nums[i]] = i;

        }
        throw new ArgumentException("No two sum solution");
    }
}
/*
   return new int[] {0, 0}; Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
   
   You may assume that each input would have exactly one solution, and you may not use the same element twice.
   
   You can return the answer in any order.
   -----------------
   
   Bir dizi nums tamsayısı ve bir hedef tamsayısı verildiğinde, hedefle toplanacak şekilde iki sayının indislerini döndürün.
   
   Her girdinin tam olarak bir çözümü olacağını varsayabilirsiniz ve aynı elemanı iki kez kullanamazsınız.
   
   Cevabı herhangi bir sırada döndürebilirsiniz.
   
   
   Example 1:
   
   Input: nums = [2,7,11,15], target = 9
   Output: [0,1]
   Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
   Example 2:
   
   Input: nums = [3,2,4], target = 6
   Output: [1,2]
   Example 3:
   
   Input: nums = [3,3], target = 6
   Output: [0,1]
    Constraints:
    
    2 <= nums.length <= 104 (nums dizisi min 2, max 104 elemanlı olmalı)
    -109 <= nums[i] <= 109 (nums dizisi i. elemanı min -109, max 109 olmalı)
    -109 <= target <= 109 (target min -109, max 109 olmalı)
    Only one valid answer exists.
    
    
    Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?
   */