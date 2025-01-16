namespace _75InterviewQuestion.ContainerWithMostWater;

public class _11_ContainerWithMostWater
{
    /*
     * 11. Container With Most Water
     In this problem, we have to find the maximum area of water that can be stored between two vertical lines.
        The width of the container is the distance between the two vertical lines.
        The height of the container is the minimum height of the two vertical lines.
        We can solve this problem by using the two-pointer technique.
        We start with two pointers, one at the beginning of the array and the other at the end of the array.
        We calculate the area between the two pointers and update the maximum area if the current area is greater.
        We then move the pointer with the smaller height towards the other pointer.
        We continue this process until the two pointers meet.

        Approach:
        - Initialize two pointers, left and right, at the beginning and end of the array, respectively.
        - Initialize a variable, maxArea, to keep track of the maximum area.
        - While the left pointer is less than the right pointer:
            - Calculate the current area between the two pointers.
            - Update the maxArea if the current area is greater.
            - Move the pointer with the smaller height towards the other pointer.
        - Return the maxArea.

        Time complexity:
        - O(n), where n is the length of the height array.

        Space complexity:
        - O(1).
     */
    public int MaxArea(int[] height)
    {
        var left = 0;
        var right = height.Length - 1;
        var maxArea = 0;

        while (left < right)
        {
            var currentArea = Math.Min(height[left], height[right]) * (right - left);
            maxArea = Math.Max(maxArea, currentArea);

            if (height[left] < height[right])
                left++;
            else
                right--;
        }

        return maxArea;
    }
}