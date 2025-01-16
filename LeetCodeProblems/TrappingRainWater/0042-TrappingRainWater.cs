namespace LeetCodeProblems.TrappingRainWater;

public class _42_TrappingRainWater
{
    /*
     Approach: Two Pointers
        1. We will use two pointers left and right and two variables leftMax and rightMax to keep track of the maximum height of the left and right side of the array.
        2. We will start from the left and right ends of the array and move the pointers towards each other.
        3. If the height of the left pointer is less than the height of the right pointer, then we will check if the height of the left pointer is greater than or equal to leftMax.
            a. If it is greater than or equal to leftMax, then we will update leftMax to the height of the left pointer.
            b. If it is less than leftMax, then we will add the difference between leftMax and the height of the left pointer to the waterTrapped variable.
            c. We will move the left pointer to the right.
        4. If the height of the right pointer is less than the height of the left pointer, then we will check if the height of the right pointer is greater than or equal to rightMax.
            a. If it is greater than or equal to rightMax, then we will update rightMax to the height of the right pointer.
            b. If it is less than rightMax, then we will add the difference between rightMax and the height of the right pointer to the waterTrapped variable.
            c. We will move the right pointer to the left.
        5. We will repeat the above steps until the left pointer is less than the right pointer.
        6. Finally, we will return the waterTrapped variable which will contain the total amount of water trapped between the blocks.

        Time Complexity: O(n)
        Space Complexity: O(1)
     */
    public int Trap(int[] height)
    {
        if (height.Length == 0) return 0;

        int left = 0, right = height.Length - 1;
        int leftMax = 0, rightMax = 0;
        var waterTrapped = 0;

        while (left < right)
            if (height[left] < height[right])
            {
                if (height[left] >= leftMax)
                    leftMax = height[left];
                else
                    waterTrapped += leftMax - height[left];
                left++;
            }
            else
            {
                if (height[right] >= rightMax)
                    rightMax = height[right];
                else
                    waterTrapped += rightMax - height[right];
                right--;
            }

        return waterTrapped;
    }
}