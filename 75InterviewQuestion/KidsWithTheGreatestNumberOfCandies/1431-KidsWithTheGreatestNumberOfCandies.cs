namespace _75InterviewQuestion.KidsWithTheGreatestNumberOfCandies;

public static class _1431_KidsWithTheGreatestNumberOfCandies
{
    /*
     * Problem: 1431. Kids With the Greatest Number of Candies
     *
     * Given the array candies and the integer extraCandies, where candies[i] represents the number of candies that the ith kid has.
     * For each kid check if there is a way to distribute extraCandies among the kids such that he or she can have the greatest number of candies among them.
     *
     * Notice that multiple kids can have the greatest number of candies.
     *
     * Approach:
     * 1. Find the maximum number of candies among all kids.
     * 2. Iterate over the candies array and check if the current kid can have the greatest number of candies by adding extraCandies.
     * 3. Return the result.
     *
     * Time complexity: O(n), where n is the length of the candies array.
     * Space complexity: O(n), where n is the length of the candies array.
     */
    public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        var maxCandies = candies.Max();
        var result = new List<bool>(candies.Length);
        result.AddRange(candies.Select(candy => candy + extraCandies >= maxCandies));

        return result;
    }
}