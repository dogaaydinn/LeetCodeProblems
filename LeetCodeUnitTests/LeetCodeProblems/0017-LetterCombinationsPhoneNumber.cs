using Xunit;
using LeetCodeProblems.LongestValidParentheses;

namespace LeetCodeTests.LeetCodeProblems
{
    public class LongestValidParenthesesTests0017
    {
        public static IEnumerable<object[]> GetTestData()
        {
            yield return new object[] { "(()", 2 };
            yield return new object[] { ")()())", 4 };
            yield return new object[] { "", 0 };
            yield return new object[] { "(", 0 };
            yield return new object[] { ")", 0 };
            yield return new object[] { "()", 2 };
            yield return new object[] { "()(()", 2 };
            yield return new object[] { "(()()", 4 };
            yield return new object[] { "(()))())(", 4 };
            yield return new object[] { "(()))())", 4 };
            yield return new object[] { "(()))())()", 8 };
            yield return new object[] { "(()))())()(", 8 };
            yield return new object[] { "(()))())()()", 10 };
            yield return new object[] { "(()))())()()(", 10 };
            yield return new object[] { "(()))())()()()()", 12 };
            yield return new object[] { "(()))())()()()()(", 12 };
            yield return new object[] { "(()))())()()()()()", 14 };
            yield return new object[] { "(()))())()()()()()(", 14 };
            yield return new object[] { "(()))())()()()()()()", 16 };
            yield return new object[] { "(()))())()()()()()()(", 16 };
        }

        [Theory]
        [MemberData(nameof(GetTestData))]
        public void LongestValidParentheses_ValidInputs_ReturnsExpectedResult1(string s, int expected)
        {
            // Arrange
            var solution = new _0032_LongestValidParentheses();

            // Act
            var result = solution.LongestValidParentheses(s);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}