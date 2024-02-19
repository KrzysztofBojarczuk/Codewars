// See https://aka.ms/new-console-template for more information


using Codewars;


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

int[] array = { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 };

var sortedArrayByZero = MoveZeroes.MoveZeroesNumber(array);

foreach (var item in sortedArrayByZero)
{
    Console.WriteLine(item);
}