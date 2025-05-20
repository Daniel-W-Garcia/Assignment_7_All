/*
1. Listen (and ask questions),
2. Generate Examples (that cover all pertinent cases and corner cases),
3. Brute Force (pseudo),
4. Optimize,
5. Walk Through,
6. Test,
7. Implement (code),
8. Test Again

Take 2 strings and shuffle them alternately.
abc, def ---> a,d,b,e,c,f

Option 1: Use string builder to build the string

sb newString = new
stringIndex for 1st string
stringIndex for 2nd string

while loop to iterate until both strings are finished
new string add character from 1st string then ++stringIndex
new string add character from 2nd string then ++stringIndex
continue patter until no mas chars in either string
return new string

Option 2: Use string concatenation to build the string
new array [1st string length + 2nd string length]

while loop to iterate until both strings are finished
new array add character from 1st string then ++stringIndex
new array add character from 2nd string then ++stringIndex
continue pattern until no mas chars in either string
return new array

*/

string MergeAlternately(string word1, string word2)
{
    var mergedString = new System.Text.StringBuilder();

    // Set up indexes to track our position in both strings
    int stringOneIndex = 0;
    int stringTwoIndex = 0;

    // Loop until we reach the end of both strings
    while (stringOneIndex < word1.Length || stringTwoIndex < word2.Length)
    {
        // If we still have characters left in word1, add the next character
        if (stringOneIndex < word1.Length)
        {
            mergedString.Append(word1[stringOneIndex]);
            stringOneIndex++; // move to next position in word1
        }

        // If we still have characters left in word2, add the next character
        if (stringTwoIndex < word2.Length)
        {
            mergedString.Append(word2[stringTwoIndex]);
            stringTwoIndex++; // move to next position in word2
        }

        // This loop continues, alternating, until both strings are finished
    }

    // Return the final merged string
    return mergedString.ToString();
}
string word1 = "HLODEAI";
string word2 = "EL EPL";
Console.WriteLine($"\nThe two strings are: \n{word1} and {word2}\n");
Console.WriteLine($"Together the merge into:\n{MergeAlternately(word1, word2)}\n");
