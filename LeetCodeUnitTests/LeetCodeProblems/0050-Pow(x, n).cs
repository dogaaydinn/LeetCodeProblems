using Xunit;
using LeetCodeProblems.Pow_x__n_; 

namespace LeetCodeTests.LeetCodeProblems
{
    public class _0050_Pow_x__n_Tests
    {
        [Fact]
        public void ExampleTest1()
        {
            // Arrange
            double x = 2.00000;
            int n = 10;
            var powXN = new _0050_Pow_x__n_();

            // Act
            double actual = powXN.MyPow(x, n);

            // Assert
            double expected = 1024.00000;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ExampleTest2()
        {
            // Arrange
            double x = 2.10000;
            int n = 3;
            var powXN = new _0050_Pow_x__n_();

            // Act
            double actual = powXN.MyPow(x, n);

            // Assert
            double expected = 9.26100;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ExampleTest3()
        {
            // Arrange
            double x = 2.00000;
            int n = -2;
            var powXN = new _0050_Pow_x__n_();

            // Act
            double actual = powXN.MyPow(x, n);

            // Assert
            double expected = 0.25000;
            Assert.Equal(expected, actual);
        }
    }
}