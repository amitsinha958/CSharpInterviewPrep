// See https://aka.ms/new-console-template for more information
using CSharpInterviewPrep;
using System.ComponentModel.DataAnnotations;

//Console.WriteLine("Hello, World!");
Console.WriteLine(ReverseString.Logic("Hello World"));
Console.WriteLine(AddODDIntegerArraySingleLine.add(new [] { 1,2,3,4,5,6,7,8,9,10}));
Console.WriteLine(PallindromeOrNot.IfPallindrome("Book"));
Console.WriteLine(PallindromeOrNot.IfPallindrome("madam"));
Console.WriteLine(ReverseOrderOfWord.ReOrder("Welcome to Csharp corner"));
Console.WriteLine(SecondLargestValueInAnArrayUsingOneLoop.SecondLargest(new[] { 8, 97, 2, 3, 4, 5, 99, 92, 98 }));
Console.WriteLine(SecondLargestValueInAnArrayUsingLoop.FindSecondLargest(new[] { 8, 97, 2, 3, 4, 5, 99, 92, 98 }));
Console.WriteLine(SecondLargestValueInAnArrayUsingLoop.FindAnyLargest(new[] { 8, 97, 2, 3, 4, 5, 99, 92, 98 },3));
string s = "Hello World";
Console.WriteLine(ReverseAString.ReverseString(ref s));
CountNoOfCharacters.CountChar("Hello World");

Dictionary<Char,int> keyValuePairs = new Dictionary<Char,int>();
string word = "Hello World";
for (int i=0; i<word.Length;i++)
{
    keyValuePairs[word[i]] = keyValuePairs.GetValueOrDefault(word[i]) + 1;
}
foreach(KeyValuePair<Char,int> keyValuePair in keyValuePairs)
Console.WriteLine(keyValuePair.Key + " = "+ keyValuePair.Value);
