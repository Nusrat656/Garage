
//Verilmiş 3 ədədən ən böyüyünü qaytaran metod yazın
//using System.Diagnostics.Metrics;
//{

//    int[] numbers = { 36, 38, 46 };
//    int largestNumber = FindLargestNumber(numbers);
//    Console.WriteLine(largestNumber);
//}

//static int FindLargestNumber(int[] numbers)
//{
//    int largest = numbers[0];
//    foreach (int num in numbers)
//    {
//        if (num > largest)
//        {
//            largest = num;
//        }
//    }
//    return largest;
//}

//IsPrime metodu - parametr olaraq ineteger value qebul edir. 
//Gonderilims integer deyerin sade olub olmadigini qaytarir.
//Eded sadedirse true, deyilse false qayitmalidir
//public class PrimeChecker
//{
//    public static bool IsPrime(int number)
//    {
//        if (number <= 1)
//            return false;

//        for (int i = 2; i * i <= number; i++)
//        {
//            if (number % i == 0)
//                return false;
//        }

//        return true;
//    }

//    public static void Main(string[] args)
//    {
//        int numberToCheck = 36; // Example number
//        Console.WriteLine("Is {0} prime? {1}", numberToCheck, IsPrime(numberToCheck));
//    }
//}