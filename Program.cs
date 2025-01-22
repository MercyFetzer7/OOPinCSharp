// User enters a quote
// Return:
// How many words
// How many characters
// How many of each letter was used


using OOPinCSharp;

string quote = ""; // set it equal to something so it's not a NULL value
int numWords = 0;

// User input
Console.WriteLine("Please enter a quote to analyze: ");
quote = Console.ReadLine(); // set user input to the quote variable

Console.WriteLine("Quote: " + quote);

WordTools wt = new WordTools(); // Declaration and Instantiation
numWords = wt.WordCounter(quote);


Console.WriteLine("Number of Words: " + numWords);

Console.WriteLine("Number of Characters: " + wt.CharacterCounter(quote));

Console.WriteLine("Alphabet: ");

wt.AlphabetCounter(quote);