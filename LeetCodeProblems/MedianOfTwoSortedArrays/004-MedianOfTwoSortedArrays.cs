namespace LeetCodeProblems.MedianOfTwoSortedArrays;

public class MedianOfTwoSortedArrays
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        // There are 2 arrays, and we need to find the median by comparing the elements without merging them
        // because the merge operation has O(m+n) complexity.
        // Why?
        /*
         * Merge sort, a divide-and-conquer algorithm, has a time complexity of O(n log n).
         * The logarithmic part comes from the repeated splitting of the array in half (logarithmic),
         * and the linear part comes from the merging of these halves (linear time).
         * Therefore, while the merging process itself is linear,
         * the overall complexity is a combination of linear and logarithmic,
         * resulting in O(n log n).
         */

        /*
         * However, the problem requires a run time complexity of O(log (m+n)).
         * We can use binary search to achieve an algorithm with O(log(min(m,n))) complexity.
         * By using binary search, we can find the median without merging the two arrays.
         *
         * To achieve this, we need to partition the arrays in such a way that the left and right sides of the partition
         * have an equal number of elements from both arrays.
         *
         * The median can be found by ensuring:
         *  - The maximum element of the left partition is less than or equal to the minimum element of the right partition.
         *
         * If this condition is not met, we adjust the partition and continue until we find the correct partition.
         */

        /*
         * Explanation:
         * We split the two arrays such that the total number of elements on the left partition
         * (from both arrays) is equal to the total number of elements on the right partition.
         * Knowing the index of a split point in one array helps us determine where to split the other array.
         *
         * Example:
         * If both arrays have a size of 100 and we partition the first array at index 30,
         * we need to partition the second array at index 70.
         *
         * Similarly, if one array has size 100 and the other has size 200,
         * partitioning the first array at index 40 means we partition the second at index 110.
         */

        // Ensure that binary search is performed on the smaller array
        if (nums1.Length > nums2.Length)
            return FindMedianSortedArrays(nums2, nums1);

        var m = nums1.Length;
        var n = nums2.Length;
        int low = 0, high = m;

        while (low <= high)
        {
            // Partition indices for both arrays
            var cut1 = (low + high) / 2;
            var cut2 = (m + n + 1) / 2 - cut1;

            // Get left and right elements at the partition
            var left1 = cut1 == 0 ? int.MinValue : nums1[cut1 - 1];
            var right1 = cut1 == m ? int.MaxValue : nums1[cut1];

            var left2 = cut2 == 0 ? int.MinValue : nums2[cut2 - 1];
            var right2 = cut2 == n ? int.MaxValue : nums2[cut2];

            // If the partition is valid, calculate the median
            if (left1 <= right2 && left2 <= right1)
            {
                if ((m + n) % 2 == 0) // Even length, return the average of the two middle elements
                    return (Math.Max(left1, left2) + Math.Min(right1, right2)) / 2.0;

                return Math.Max(left1, left2); // Odd length, return the middle element
            }

            // Adjust binary search range
            if (left1 > right2)
                high = cut1 - 1;
            else
                low = cut1 + 1;
        }

        throw new ArgumentException("Input arrays are not sorted.");
    }
}