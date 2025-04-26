using dotnetlab.lab2;
internal class Program
{
    private static void Main(string[] args)
    {
        //1. PROGRAM TO PRINT HELLO AND NAME IN SEPARATE 
        Console.WriteLine("Hello");
        Console.WriteLine("Rashik Prajapati\n");


        //2. PROGRAM TO SWAP TWO NUMBERS
        Console.WriteLine("SWAPPING NUMBERS");
        Console.WriteLine("Enter first number:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("num1 = " + num1);
        Console.WriteLine("num2 = " + num2);
        int temp = num1;
        num1 = num2;
        num2 = temp;
        Console.WriteLine("num1 = " + num1);
        Console.WriteLine("num2 = " + num2 + "\n");


        //3. PROGRAM TO FIND THE LARGEST OF THREE NUMBERS
        Console.WriteLine("LARGEST OF THREE NUMBERS");
        Console.WriteLine("Enter first number");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number");
        int n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number");
        int n3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("num1 = " + n1);
        Console.WriteLine("num2 = " + n2);
        Console.WriteLine("num3 = " + n3);
        Check L = new Check();
        int Largest = L.isLarge(n1, n2, n3);
        Console.WriteLine(Largest + " is the largest of three numbers.\n");


        //4. PROGRAM TO CHECK GIVEN NUMBER IS ODD OR EVEN
        Console.WriteLine("ODD OR EVEN");
        Console.WriteLine("Enter a number to check odd or even");
        int number = Convert.ToInt32(Console.ReadLine());
        Check oddEven = new Check();
        if (oddEven.isOddEven(number))
        {
            Console.WriteLine("Given number " + number + " is even\n");
        }
        else
        {
            Console.WriteLine("Given number " + number + " is odd\n");
        }


        //5. PROGRAM TO DISPLAY SUM OF N NATURAL NUMBERS
        Console.WriteLine("SUM OF n NATURAL NUMBERS");
        Console.WriteLine("How many numbers do you want to add?");
        int n = Convert.ToInt32(Console.ReadLine());
        Sum S = new Sum();
        int sumResult = S.sumNatural(n);
        Console.WriteLine("Sum of " + n + " natural numbers = " + sumResult + "\n");


        //6. PROGRAM TO CHECK GIVEN YEAR IS A LEAP YEAR OR NOT.
        Console.WriteLine("LEAP YEAR");
        Console.WriteLine("Enter year to check leap year.");
        int year = Convert.ToInt32(Console.ReadLine());
        Check yr = new Check();
        if (yr.isLeap(year))
        {
            Console.WriteLine("The year " + year + " is leap year\n");
        }
        else
        {
            Console.WriteLine("The year " + year + " is not leap year\n");
        }


        //7. PROGRAM TO CREATE INTEGER ARRAY AND PRINT SUM OF ARRAY ELELMENT
        Console.WriteLine("SUM OF ARRAY ELEMENT");
        Console.WriteLine("How many numbers do you want to add?");
        int nA = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[nA];
        Console.WriteLine("Enter the numbers for array.");
        for (int j = 0; j < nA; j++)
        {
            arr[j] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Contents of array:");
        for (int j = 0; j < nA; j++)
        {
            Console.WriteLine(arr[j]);
        }
        Sum SA = new Sum();
        int sumArrayResult = SA.sumArray(nA, arr);
        Console.WriteLine("Sum of " + nA + " natural numbers = " + sumArrayResult + "\n");


        //8. PROGRAM TO CALCULATE THE FACTORAL OF GIVEN NUMBER
        Console.WriteLine("FACTORIAL OF NUMBER");
        Console.WriteLine("Enter a number to calculate factorial:");
        int numFactorial = Convert.ToInt32(Console.ReadLine());
        Factorial Fact = new Factorial();
        int factorialResult = Fact.Facto(numFactorial);
        Console.WriteLine("The factorial of given number is " + factorialResult + "\n");


        //9. PROGRAM TO CHECK IF INPUT NUMBER IS A PRIME NUMBER OR NOT
        Console.WriteLine("PRIME NUMBER");
        Console.WriteLine("Enter number to check the number is prime or not:");
        int numPrime = Convert.ToInt32(Console.ReadLine());
        Check prime = new Check();
        bool isPrimeCheck = prime.isPrime(numPrime);
        if (isPrimeCheck)
        {
            Console.WriteLine("The number " + numPrime + " is prime number.\n");
        }
        else
        {
            Console.WriteLine("The number " + numPrime + " is not prime number.\n");
        }
    }
}