namespace LeetCodeProblems.Pow_x__n_;

public class _0050_Pow_x__n_
{
    /*
     Intuition:
     To calculate ( x^n ), we can use the divide-and-conquer approach. 
     If ( n ) is even, we can split the problem into two smaller subproblems of size ( n/2 ).
      If ( n ) is odd, we can split it into two smaller subproblems of size ( n/2 ) and multiply the result by ( x ).
      
      Approach:
       1- If ( n ) is 0, return 1 because any number raised to the power of 0 is 1.
       2- If ( n ) is negative, convert the problem to ( 1/x ) and ( -n ).
       3- Use a helper function to recursively calculate the power:
            -If ( n ) is 0, return 1.
            -Calculate the power of ( x ) to ( n/2 ).
            -If ( n ) is even, return the square of the result.
            -If ( n ) is odd, return the square of the result multiplied by ( x ).
          
         Time complexity:  
        The time complexity is ( O(\log n) ) because we are dividing the problem size by 2 at each step.
        
        Space complexity:
        The space complexity is ( O(\log n) ) due to the recursion stack.
     */
    public double MyPow(double x, int n)
    {
        switch (n)
        {
            case 0:
                return 1;
            case < 0:
                x = 1 / x;
                n = -n;
                break;
        }

        return PowHelper(x, n);
    }

    private double PowHelper(double x, int n)
    {
        if (n == 0) return 1;
        double half = PowHelper(x, n / 2);
        if (n % 2 == 0)
            return half * half;
        return half * half * x;
    }
}