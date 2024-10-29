namespace _75InterviewQuestion.ContainerWithMostWater;

public class _11_ContainerWithMostWater
{
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