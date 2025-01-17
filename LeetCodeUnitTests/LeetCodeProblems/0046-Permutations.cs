using Xunit;
using System.Collections.Generic;

namespace LeetCodeTests.LeetCodeProblems
{
    public class _0046_Permutations
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            var result = new List<IList<int>>();
            Backtrack(nums, new List<int>(), result);
            return result;
        }

        private void Backtrack(int[] nums, List<int> current, List<IList<int>> result)
        {
            if (current.Count == nums.Length)
            {
                result.Add(new List<int>(current));
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (current.Contains(nums[i])) continue;
                current.Add(nums[i]);
                Backtrack(nums, current, result);
                current.RemoveAt(current.Count - 1);
            }
        }

        [Fact]
        public void PermuteTest()
        {
            // Arrange
            var problem = new _0046_Permutations();
            var nums = new int[] { 1, 2, 3 };
            var expected = new List<IList<int>> {
                new List<int> { 1, 2, 3 },
                new List<int> { 1, 3, 2 },
                new List<int> { 2, 1, 3 },
                new List<int> { 2, 3, 1 },
                new List<int> { 3, 1, 2 },
                new List<int> { 3, 2, 1 }
            };

            // Act
            var result = problem.Permute(nums);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}