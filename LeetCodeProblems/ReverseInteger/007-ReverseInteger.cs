namespace LeetCodeProblems.ReverseInteger;

public class ReverseInteger {
    
    public int Reverse(int x) {
        
        var reversed = 0;
        
        while (x != 0)
        {
            var pop = x % 10;
            x /= 10;
            
            switch (reversed)
            {
                case > int.MaxValue / 10:
                case int.MaxValue / 10 when pop > 7:
                case < int.MinValue / 10:
                case int.MinValue / 10 when pop < -8:
                    return 0;
                default:
                    reversed = reversed * 10 + pop;
                    break;
            }
        }
        
        return reversed;
    }
}