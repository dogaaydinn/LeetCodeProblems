namespace _75InterviewQuestion.KidsWithTheGreatestNumberOfCandies
{
    public class KidsWithTheGreatestNumberOfCandies
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            var maxCandies = candies.Max();
            var result = new List<bool>(candies.Length);
            result.AddRange(candies.Select(candy => candy + extraCandies >= maxCandies));

            return result;
        }
    }
}