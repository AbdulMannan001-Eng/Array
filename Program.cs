// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices.Marshalling;
using ArrayClassWork;
class Program
{
    static void Main()
    {
        ArrayOperations arrayOperations = new ArrayOperations();
        int[] numbers = { 2, 4, 6, 8, 10};
        int sum = arrayOperations.SumArray(numbers);
        Console.WriteLine("Sum of Array elements:" + sum);
    }
}

