namespace _75InterviewQuestion.CanPlaceFlowers;

public class CanPlaceFlowers {
    public bool CanPlace(int[] flowerbed, int n) {

        var count = 0;
        var i = 0;
        
        while (i < flowerbed.Length)
        {
            if (flowerbed[i] == 0 && (i == 0 || flowerbed[i - 1] == 0) && (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0))
            {
                flowerbed[i] = 1;
                count++;
            }

            i++;
        }

        return count >= n;
    }
}