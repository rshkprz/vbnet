using oop;

internal class Program
{
    private static void Main(string[] args)
    {
        //MathOperations maths = new MathOperations();
        //var addInt = maths.Add(8, 9);
        //Console.WriteLine("Addition of two integers =" + addInt);
        //var addDouble = maths.Add(89.32, 91.2);
        //Console.WriteLine("Addition of two Doubles =" + addDouble);
        //var mulInt = maths.Multiply(8, 9);
        //Console.WriteLine("Multiply of two integers =" + mulInt);
        //var mulDouble = maths.Multiply(8.5, 9.2);
        //Console.WriteLine("Multiply of two doubles =" + mulDouble);

        //MathOpeartion iO = new MathOpeartion();
        //var addIdouble = iO.Add(5.5, 3.0);
        //Console.WriteLine("Addition of two Doubles =" + addIdouble);
        //var subIdouble = iO.Subtract(5.5, 3.0);
        //Console.WriteLine("Addition of two Doubles =" + subIdouble);
        //var mulIdouble = iO.Multiply(5.5, 3.0);
        //Console.WriteLine("Multiply of two Doubles =" + mulIdouble);
        //var divIdouble = iO.Add(5.5, 3.0);
        //Console.WriteLine("Addition of two Doubles =" + addIdouble);

        Console.WriteLine("Enter a word to check palindrome");
        string inputString = Console.ReadLine();
        Palindrome p = new Palindrome();
        bool isPalindrome = p.CheckPalindrome(inputString);
        if (isPalindrome)
        {
            Console.WriteLine("The input string " + inputString + " is palidrome");
        }
        else
        {
            Console.WriteLine("The input string " + inputString + " is not palindrome");
        }
    }
}