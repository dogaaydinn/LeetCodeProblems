namespace LeetCodeProblems.MedianOfTwoSortedArrays;

public static class _004_MedianOfTwoSortedArrays
{
    /*
        * Problem:
        * Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
        * The overall run time complexity should be O(log (m+n)).

        * Approach:
        1. If the length of nums1 is greater than the length of nums2, swap the arrays.
        2. Get the lengths of the arrays.
        3. Set low to 0 and high to m.
        4. Iterate while low is less than or equal to high.
        5. Calculate cut1 and cut2.
        6. Get the left1, right1, left2, and right2 values.
        7. If left1 is less than or equal to right2 and left2 is less than or equal to right1, return the median.
        8. If the total length of the arrays is even, return the average of the maximum of left1 and left2 and the minimum of right1 and right2.
        9. Otherwise, return the maximum of left1 and left2.
        10. If left1 is greater than right2, set high to

        Time complexity: O(log(min(m, n)))
        Space complexity: O(1)
     */
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