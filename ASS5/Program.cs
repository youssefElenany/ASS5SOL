namespace ASS5
{
    internal class Program
    {
        #region Methods
        //static void PassByValue(int number)
        //{
        //    number = 20;
        //}

        //Pass by Reference
        //static void PassByReference(ref int number)
        //{
        //    number = 20;
        //} 

        //Q3
        //public static void SumSub(int x, int y , out int sum , out int sub)
        //{
        //     sum = x + y;
        //     sub = x - y;
        //}
        //Q4
        //static int SumOfDigits(int number)
        //{
        //    int sum = 0;
        //    while (number != 0)
        //    {
        //        sum += number % 10;
        //        number /= 10;
        //    }
        //    return sum;
        //}
        //Q5
        //static bool IsPrime(int number)
        //{
        //    if (number < 2) return false;
        //    for (int i = 2; i <= Math.Sqrt(number); i++)
        //    {
        //        if (number % i == 0) return false;
        //    }
        //    return true;
        //}
        //Q6
        //static void MinMaxArray(int[] array, out int min, out int max)
        //{
        //    min = array[0];
        //    max = array[0];
        //    foreach (int num in array)
        //    {
        //        if (num < min) min = num;
        //        if (num > max) max = num;
        //    }
        //}

        //Q7
        //static int Factorial(int number)
        //{
        //    int result = 1;
        //    for (int i = 2; i <= number; i++)
        //    {
        //        result *= i;
        //    }
        //    return result;
        //}


        #endregion

        static void Main(string[] args)
        {
            #region Q1
            //int num = 10;

            //// Pass by Value
            //PassByValue(num);
            //Console.WriteLine($"After PassByValue: {num}"); // Output: 10



            #endregion

            #region Q2
            //pass by reference

            //PassByReference(ref num);
            //Console.WriteLine($"after passbyreference: {num}"); // output: 20
            #endregion

            #region Q3
            //int A = 20 , B = 10 ;
            //int sumresult, subresult;
            //Program.SumSub(A ,B , out sumresult, out subresult);
            //Console.WriteLine(sumresult);
            //Console.WriteLine(subresult);
            #endregion

            #region Q4
            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());

            //Console.WriteLine($"The sum of the digits of the number {num} is: {SumOfDigits(num)}");

            #endregion

            #region Q5
            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());

            //Console.WriteLine($"{num} is {(IsPrime(num) ? "a prime" : "not a prime")} number.");

            #endregion

            #region Q6
            //int[] numbers = { 4, 7, 2, 10, 3 };

            //MinMaxArray(numbers, out int min, out int max);
            //Console.WriteLine($"Minimum: {min}, Maximum: {max}");

            #endregion

            #region Q7
            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Factorial of {num} is: {Factorial(num)}");

            #endregion

            #region Q8

            #endregion

        }
    }
    }
