// See https://aka.ms/new-console-template for more information


using Codewars;
using System.Text;
using System.Linq;
//class Threed

Console.WriteLine("Program rozpoczął działanie.");

// Tworzenie nowego wątku i przypisanie do niego metody WykonajPracę
var t = new Thread(WykonajPracę);

Console.WriteLine("Wątek został utworzony, teraz go uruchamiamy.");
t.Start();

// Czekanie na zakończenie działania wątku
Console.WriteLine("Czekam na zakończenie wątku.");
t.Join();

Console.WriteLine("Wątek zakończył działanie. Program kończy działanie.");


static void WykonajPracę()
{
    Console.WriteLine("Wątek zaczyna pracę.");
    Thread.Sleep(5000);  // Symulacja długotrwałej operacji
    Console.WriteLine("Wątek kończy pracę.");
}
//1 Count of positives / sum of negatives

//int[] inputArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };

//ArrayProcessor arrayProcessor = new ArrayProcessor();

//int[] result = arrayProcessor.CountPositivesSumNegatives(inputArray);

//Console.WriteLine("Result: [" + string.Join(", ", result) + "]");


//2 Description:
//Remove all exclamation marks from the end of sentence.

//Examples
//"Hi!"     ---> "Hi"
//"Hi!!!"   ---> "Hi"
//"!Hi"     ---> "!Hi"
//"!Hi!"    ---> "!Hi"
//"Hi! Hi!" ---> "Hi! Hi"
//"Hi"      ---> "Hi"

//Console.WriteLine(Kata.Remove("Hi!"));     
//Console.WriteLine(Kata.Remove("Hi!!!"));   
//Console.WriteLine(Kata.Remove("!Hi"));     
//Console.WriteLine(Kata.Remove("!Hi!"));    
//Console.WriteLine(Kata.Remove("Hi! Hi!")); 
//Console.WriteLine(Kata.Remove("Hi"));      


// 33

//Return the number (count) of vowels in the given string.

//We will consider a, e, i, o, u as vowels for this Kata (but not y).

//The input string will only consist of lower case letters and/or spaces.

//4 Build a pile of Cubes

//Console.WriteLine(ASum.findNb(1071225));


//5 Ciąg Fibacciniego

//Console.Write("Podaj ilość elementów ciągu Fibonacciego do wygenerowania: ");
//int n = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Ciąg Fibonacciego:");

//for (int i = 0; i < n; i++)
//{
//    Console.Write(Fib.Fibonacci(i) + " ");
//}

//6 FizzBuzz
//FizzBuzz.FizzBuzzList();
//8 Palindrome

//var palindrom = new Palindrome();

//Console.WriteLine("Enter the word to check:");
//string input = Console.ReadLine();

//string resultMessage = palindrom.IsPalindromeLong(input) ? "Word is palindrome." : "Word is not palindrome.";
//Console.WriteLine(resultMessage);

//9

//Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.

//Kata.MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 }) => new int[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 }

//int[] array = { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 };

//var sortedArrayByZero = MoveZeroes.MoveZeroesNumber(array);

//foreach (var item in sortedArrayByZero)
//{
//    Console.WriteLine(item);
//}

// 10Very simple, given a number (integer / decimal / both depending on the language), find its opposite (additive inverse).

//var opositeNumber = OppositeNum.GetOpposite(10);
//Console.WriteLine(opositeNumber);

//var negativeNumber = OppositeNum.MakePositive(-12);
//Console.WriteLine(negativeNumber);


//11 A format for expressing an ordered list of integers is to use a comma separated list of either

//individual integers
//or a range of integers denoted by the starting integer separated from the end integer in the range by a dash, '-'. The range includes all integers in the interval including both endpoints. It is not considered a range unless it spans at least 3 numbers. For example "12,13,15-17"
//Complete the solution so that it takes a list of integers in increasing order and returns a correctly formatted string in the range format.

//RangeExtraction range = new RangeExtraction();

//int[] array = [-10, -9, -8, -6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20];

//var extractedArray = range.Extract(array);

//Console.WriteLine(string.Join(",", extractedArray));

//12 
//Write a program in C# Sharp to show how the three parts of a query operation execute.
//Expected Output:
//The numbers which produce the remainder 0 after divided by 2 are :
//0 2 4 6 8
//int[] n1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//Exe1 exe1 = new Exe1(n1);

//var numbers = exe1.Calc();

//foreach (var item in numbers)
//{
//    Console.WriteLine(item);
//}
//13Write a program in C# Sharp to find the +ve numbers from a list of numbers using two where conditions in LINQ Query.
//Expected Output:
//The numbers within the range of 1 to 11 are :

//int[] n1 = new int[] { 1, 3, 6, 9, 10 };

//Exe1 exe1 = new Exe1(n1);

//var numbers = exe1.Range();

//foreach (var item in numbers)
//{
//    Console.WriteLine(item);
//}

//14 Write a program in C# Sharp to find the number of an array and the square of each number which is more than 20.

//int[] n1 = new int[] { 3, 9, 2, 8, 6, 5 };

//Exe1 exe1 = new Exe1(n1);

//exe1.DisplayNumbersWithSquaresGreaterThan20();

//15  Write a program in C# Sharp to display the number and frequency of a given number from an array.

//int[] n1 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

//Exe1 exe1 = new Exe1(n1);

//exe1.DispalyNumberByFrequency();

//16 Write a program in C# Sharp to display the characters and frequency of each character in a given string.

//Exe1 exe1 = new Exe1(n1);

//exe1.DispalyCharacterFrequency();