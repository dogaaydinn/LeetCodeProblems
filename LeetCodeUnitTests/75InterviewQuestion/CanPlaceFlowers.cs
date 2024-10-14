using _75InterviewQuestion.CanPlaceFlowers;
using Xunit;

namespace LeetCodeTests._75InterviewQuestion;

public class CanPlaceFlowers
{
    [Fact]
    public void CanPlace_ReturnsTrue_WhenPossible()
    {
        int[] flowerbed = { 1, 0, 0, 0, 1 };
        const int n = 1;

        var result = _605_CanPlaceFlowers.CanPlace(flowerbed, n);

        Assert.True(result);
    }

    [Fact]
    public void CanPlace_ReturnsFalse_WhenNotPossible()
    {
        int[] flowerbed = { 1, 0, 0, 0, 1 };
        const int n = 2;

        var result = _605_CanPlaceFlowers.CanPlace(flowerbed, n);

        Assert.False(result);
    }
}