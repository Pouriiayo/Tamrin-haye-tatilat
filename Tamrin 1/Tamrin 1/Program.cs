int n = GetinputOutput.GetPostiveNumber();
int m = GetinputOutput.GetPostiveNumber();

for (int i = Math.Min(n, m); i < Math.Max(n , m); i++){

    Console.Write(i + ": ");
    GetinputOutput.Print(Calculation.IsPrime(i) , "Aval");
    GetinputOutput.Print(Calculation.IsOdd(i), "Fard");
    GetinputOutput.Print(Calculation.IsPalindrome(i), "palindrome");
    GetinputOutput.Print(Calculation.isComplete(i), "Kamel");

    Console.WriteLine();
}
