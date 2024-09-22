namespace _75InterviewQuestion.GreatestCommonDivisorOfStrings
{
    public class GreatestCommonDivisorOfStrings
    {
        public string GcdOfStrings(string str1, string str2)
        {
            var gcdLength = HCD(str1.Length, str2.Length);
            var candidate = str1.Substring(0, gcdLength);

            if (str1.Replace(candidate, "") == "" && str2.Replace(candidate, "") == "")
            {
                return candidate;
            }

            return "";

            int HCD(int a, int b)
            {
                while (b != 0)
                {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }

                return a;
            }
        }
    }
}