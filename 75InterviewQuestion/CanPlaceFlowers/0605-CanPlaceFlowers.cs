namespace _75InterviewQuestion.CanPlaceFlowers;

public static class _605_CanPlaceFlowers
{
    /*
        * 605. Can Place Flowers
     In this problem, we need to find out if we can place n flowers in the flowerbed without violating the no-adjacent-flowers rule.
        The rule is that two flowers cannot be adjacent to each other.
        We can solve this problem by iterating over the flowerbed and checking if the current position is a valid place to plant a flower.
        If it is, we plant a flower and increment the count of planted flowers.
        Finally, we return true if the count of planted flowers is greater than or equal to n.

        Approach:
        - Initialize a count variable to keep track of the number of flowers planted.
        - Iterate over the flowerbed array.
        - Check if the current position is a valid place to plant a flower:
            - The current position is empty (flowerbed[i] == 0).
            - The previous position is empty (i == 0 or flowerbed[i - 1] == 0).
            - The next position is empty (i == flowerbed.Length - 1 or flowerbed[i + 1] == 0).
        - If the current position is a valid place to plant a flower, plant a flower and increment the count.
        - Return true if the count of planted flowers is greater than or equal to n.

        Time complexity:
        - O(n), where n is the length of the flowerbed array.

        Space complexity:
        - O(1).
     */
    public static bool CanPlace(int[] flowerbed, int n)
    {
        var count = 0;
        var i = 0;

        while (i < flowerbed.Length)
        {
            if (flowerbed[i] == 0 && (i == 0 || flowerbed[i - 1] == 0) &&
                (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0))
            {
                flowerbed[i] = 1;
                count++;
            }

            i++;
        }

        return count >= n;
    }
}