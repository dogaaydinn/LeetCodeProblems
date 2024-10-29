namespace Example.AIQuestions;

public class UniqueInteger
{
    //All elements in an array occur three times, only one element occurs twice. Find this element.
    public int FindDuplicate(int[] nums)
    {
        int seenOnce = 0, seenTwice = 0;
        foreach (var num in nums)
        {
            seenOnce = ~seenTwice & (seenOnce ^ num);
            seenTwice = ~seenOnce & (seenTwice ^ num);
        }

        return seenOnce;
    }
}