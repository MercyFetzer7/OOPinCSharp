namespace OOPinCSharp
{
    internal class WordTools
    {
        public int WordCounter(string words)
        {
            int wordCount = 0;
            
            // this is splitting the string into separate words to make it easier to count
            string [] individualWords = words.Split(' '); // this is a function that splits up a string based in what you want
            
            wordCount = individualWords.Length;
            return (wordCount);
        }

        public int CharacterCounter(string words)
        {
            int characterCount = 0;
            characterCount = words.Length;
            return (characterCount);
        }

        public void AlphabetCounter(string words)
        {
            int[] letters = new int[26]; // for the alphabet, beginning with 'a' and going to 'z'

            // Loop through the entire string
            for (int i = 0; i < words.Length; i++) // i++ increments i by 1
            {
                char c = words[i];
                
                c = Char.ToLower(c); // char is a library
                
                // Check to make sure it is a lowercase letter
                if (c >= 97 && c <= 122)
                { 
                    letters[(c - 97)]++;
                }
            }
            // Print results from the array
            for (int i = 0; i < letters.Length; i++)
            {
                char letter = (char)(i + 97);
                Console.WriteLine(letter + ": " + letters[i]);
            }
        }
    }
}
