namespace _75InterviewQuestion.ContainerWithMostWater;

public class _11_ContainerWithMostWater {
    public int MaxArea(int[] height)
    {
        int left = 0;
        int right = height.Length - 1;
        int maxArea = 0;

        while (left<right)
        {
            int currentArea = Math.Min(height[left], height[right]) * (right - left);
            maxArea = Math.Max(maxArea, currentArea);

            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return maxArea;
    }
}