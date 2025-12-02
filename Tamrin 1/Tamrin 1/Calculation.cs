public class Calculation
{
    static public bool IsPrime(int number)
    {
        bool check = true;
        for (int i = 2; i < Math.Sqrt(number); i++)
            if (number % i == 0)
                check = false;
        return check;
    }
    static public bool IsOdd(int number)
    {
        bool check;
        if (number % 2 == 0)
            check = false;
        else
            check = true;
        return check;
    }
    static public bool IsPalindrome(int number)
    {
        string str = number.ToString();
        char[] chars = str.ToCharArray();
        Array.Reverse(chars);
        string reversed = new string(chars);

        return str == reversed;
    }

    static public bool isComplete(int number) {
        int sum = 0;
        for (int i = number - 1; i >= 1; i--) { 
            if (number % i == 0)
            {
                sum += i;
            }
        }

        if(sum == number)
        {
            return true;
        }
        return false;
    }
}