public class GetinputOutput
{
    public static int GetPostiveNumber()
    {
        bool isDigit;
        string input;
        do
        {
            Console.WriteLine("adad vared konid: ");
            input = Console.ReadLine();
            isDigit = input.All(char.IsDigit);
            if (isDigit == false)
            {
                Console.WriteLine("adad sahih nist...mojadad talash konid");
            }

        } while (isDigit == false);
        int number = Convert.ToInt32(input);
        return number;
    }
    static public void Print(bool check, string message)
    {
        if (check == true)
            Console.Write($"adad {message} ast. ");
        else
            Console.Write($"adad {message} nist. ");
    }
}