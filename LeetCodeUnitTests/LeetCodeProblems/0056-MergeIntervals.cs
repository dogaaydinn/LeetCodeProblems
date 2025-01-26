using Xunit;
using LeetCodeProblems.MergeIntervals;
using System.Collections.Generic;

namespace MergeIntervalsTests
{
    public class MergeIntervalsTests
    {
        private readonly MergeIntervals.MergeIntervals _mergeIntervals;

        public MergeIntervalsTests()
        {
            _mergeIntervals = new MergeIntervals.MergeIntervals();
        }

        [Fact]
        public void Merge_EmptyInput_ReturnsEmpty()
        {
            // Arrange
            int[][] intervals = new int[0][];

            // Act
            var result = _mergeIntervals.Merge(intervals);

            // Assert
            Assert.NotNull(result);
            Assert.Empty(result);
        }

        [Fact]
        public void Merge_SingleInterval_ReturnsSameInterval()
        {
            // Arrange
            int[][] intervals = new int[][]
            {
                new int[] {1, 3}
            };
            int[][] expected = new int[][]
            {
                new int[] {1, 3}
            };

            // Act
            var result = _mergeIntervals.Merge(intervals);

            // Assert
            Assert.Equal(expected.Length, result.Length);
            Assert.Equal(expected[0], result[0]);
        }

        [Fact]
        public void Merge_NoOverlappingIntervals_ReturnsSortedIntervals()
        {
            // Arrange
            int[][] intervals = new int[][]
            {
                new int[] {5, 7},
                new int[] {1, 3},
                new int[] {8, 10}
            };
            int[][] expected = new int[][]
            {
                new int[] {1, 3},
                new int[] {5, 7},
                new int[] {8, 10}
            };

            // Act
            var result = _mergeIntervals.Merge(intervals);

            // Assert
            Assert.Equal(expected.Length, result.Length);
            for(int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], result[i]);
            }
        }

        [Fact]
        public void Merge_AllOverlappingIntervals_ReturnsSingleMergedInterval()
        {
            // Arrange
            int[][] intervals = new int[][]
            {
                new int[] {1, 4},
                new int[] {2, 5},
                new int[] {3, 6}
            };
            int[][] expected = new int[][]
            {
                new int[] {1, 6}
            };

            // Act
            var result = _mergeIntervals.Merge(intervals);

            // Assert
            Assert.Equal(expected.Length, result.Length);
            Assert.Equal(expected[0], result[0]);
        }

        [Fact]
        public void Merge_SomeOverlappingIntervals_ReturnsCorrectMerges()
        {
            // Arrange
            int[][] intervals = new int[][]
            {
                new int[] {1, 3},
                new int[] {2, 6},
                new int[] {8, 10},
                new int[] {15, 18}
            };
            int[][] expected = new int[][]
            {
                new int[] {1, 6},
                new int[] {8, 10},
                new int[] {15, 18}
            };

            // Act
            var result = _mergeIntervals.Merge(intervals);

            // Assert
            Assert.Equal(expected.Length, result.Length);
            for(int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], result[i]);
            }
        }

        [Fact]
        public void Merge_UnsortedIntervals_ReturnsSortedMergedIntervals()
        {
            // Arrange
            int[][] intervals = new int[][]
            {
                new int[] {6, 8},
                new int[] {1, 9},
                new int[] {2, 4},
                new int[] {4, 7}
            };
            int[][] expected = new int[][]
            {
                new int[] {1, 9}
            };

            // Act
            var result = _mergeIntervals.Merge(intervals);

            // Assert
            Assert.Equal(expected.Length, result.Length);
            Assert.Equal(expected[0], result[0]);
        }

        [Fact]
        public void Merge_IntervalsWithSameStart_ReturnsCorrectMerges()
        {
            // Arrange
            int[][] intervals = new int[][]
            {
                new int[] {1, 4},
                new int[] {1, 5},
                new int[] {1, 3}
            };
            int[][] expected = new int[][]
            {
                new int[] {1, 5}
            };

            // Act
            var result = _mergeIntervals.Merge(intervals);

            // Assert
            Assert.Equal(expected.Length, result.Length);
            Assert.Equal(expected[0], result[0]);
        }

        [Fact]
        public void Merge_IntervalsWithSameEnd_ReturnsCorrectMerges()
        {
            // Arrange
            int[][] intervals = new int[][]
            {
                new int[] {1, 5},
                new int[] {2, 5},
                new int[] {3, 5}
            };
            int[][] expected = new int[][]
            {
                new int[] {1, 5}
            };

            // Act
            var result = _mergeIntervals.Merge(intervals);

            // Assert
            Assert.Equal(expected.Length, result.Length);
            Assert.Equal(expected[0], result[0]);
        }

        [Fact]
        public void Merge_IntervalsContainingNegativeNumbers_ReturnsCorrectMerges()
        {
            // Arrange
            int[][] intervals = new int[][]
            {
                new int[] {-10, -1},
                new int[] {-5, 0},
                new int[] {1, 3}
            };
            int[][] expected = new int[][]
            {
                new int[] {-10, 0},
                new int[] {1, 3}
            };

            // Act
            var result = _mergeIntervals.Merge(intervals);

            // Assert
            Assert.Equal(expected.Length, result.Length);
            for(int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], result[i]);
            }
        }

        [Fact]
        public void Merge_LargeNumberOfIntervals_PerformanceTest()
        {
            // Arrange
            int n = 10000;
            int[][] intervals = new int[n][];
            for(int i = 0; i < n; i++)
            {
                intervals[i] = new int[] { i * 2, i * 2 + 1 };
            }
            int[][] expected = new int[n][];
            for(int i = 0; i < n; i++)
            {
                expected[i] = new int[] { i * 2, i * 2 + 1 };
            }

            // Act
            var result = _mergeIntervals.Merge(intervals);

            // Assert
            Assert.Equal(expected.Length, result.Length);
            for(int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], result[i]);
            }
        }

        [Fact]
        public void Merge_IntervalsWithIdenticalStartAndEnd_ReturnsSingleMergedInterval()
        {
            // Arrange
            int[][] intervals = new int[][]
            {
                new int[] {2, 2},
                new int[] {2, 2},
                new int[] {2, 2}
            };
            int[][] expected = new int[][]
            {
                new int[] {2, 2}
            };

            // Act
            var result = _mergeIntervals.Merge(intervals);

            // Assert
            Assert.Equal(expected.Length, result.Length);
            Assert.Equal(expected[0], result[0]);
        }
    }
}
