﻿// See https://aka.ms/new-console-template for more information


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

Console.WriteLine(Kata.Remove("Hi!"));      // Output: "Hi"
Console.WriteLine(Kata.Remove("Hi!!!"));   // Output: "Hi"
Console.WriteLine(Kata.Remove("!Hi"));     // Output: "!Hi"
Console.WriteLine(Kata.Remove("!Hi!"));    // Output: "!Hi"
Console.WriteLine(Kata.Remove("Hi! Hi!")); // Output: "Hi! Hi"
Console.WriteLine(Kata.Remove("Hi"));      // Output: "Hi"
