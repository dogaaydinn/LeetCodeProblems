namespace LeetCodeProblems.MedianOfTwoSortedArrays;

public static class _004_MedianOfTwoSortedArrays
{
    public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        while (true)
        {
            
            if (nums1.Length > nums2.Length)
            {
                (nums1, nums2) = (nums2, nums1);
                continue;
            }

            var m = nums1.Length;
            var n = nums2.Length;
            int low = 0, high = m;

            while (low <= high)
            {
                var cut1 = (low + high) / 2;
                var cut2 = (m + n + 1) / 2 - cut1;
                
                var left1 = cut1 == 0 ? int.MinValue : nums1[cut1 - 1];
                var right1 = cut1 == m ? int.MaxValue : nums1[cut1];

                var left2 = cut2 == 0 ? int.MinValue : nums2[cut2 - 1];
                var right2 = cut2 == n ? int.MaxValue : nums2[cut2];
                
                if (left1 <= right2 && left2 <= right1)
                {
                    if ((m + n) % 2 == 0) 
                        return (Math.Max(left1, left2) + Math.Min(right1, right2)) / 2.0;

                    return Math.Max(left1, left2); 
                }
                
                if (left1 > right2)
                    high = cut1 - 1;
                else
                    low = cut1 + 1;
            }

            throw new ArgumentException("Input arrays are not sorted.");
        }
    }
}