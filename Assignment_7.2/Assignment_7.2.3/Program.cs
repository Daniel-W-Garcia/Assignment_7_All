/*

1. Listen (and ask questions),
2. Generate Examples (that cover all pertinent cases and corner cases),
3. Brute Force (pseudo),
4. Optimize,
5. Walk Through,
6. Test,
7. Implement (code),
8. Test Again

compare 2 strings to see if they are anagrams
are we considering case?
are we considering spaces?
are we considering punctuation?

life <-> file = true
lift <-> file = false
can't <-> tanc = true

strip strings of all non-alphanumeric characters
compare stripped strings
if length isn't the same, return false
how do we compare 2 strings in a loop???
wait, we can strip then sort them alpha numerically
then just do a straight compare

option 1 use sb 
string one we strip and save as sb1
string two we strip and save as sb2
sb1.sort()
sb2.sort()
if (sb1.ToString() == sb2.ToString())
    return true
else
    return false

option 2 create 2 arrays of chars. 
iterate through both arrays, compare chars. 
2 pointers
left pointer for first array
2nd pointer for second array
only increment left pointer if char matches
    - need to account for doubles so would need to move the matched char to the beginning of the array and then start from index +1 next round for the right array
so it looks like this:
left pointer = 0
right pointer = 0

*/

using System.Text;




string StripString(string str)
{
    var sb = new StringBuilder();
    foreach (var c in str.ToLower())
    {
        if (char.IsLetterOrDigit(c))
        {
            sb.Append(c);
        }
    }
    char[] chars = sb.ToString().ToCharArray();
    Array.Sort(chars);
    return new string(chars);
}

bool IsAnagram(string str1, string str2)
{
    var sb1 = StripString(str1);
    var sb2 = StripString(str2);
    if (sb1.Length != sb2.Length)
    {
        return false;
    }

    for (int i = 0; i < sb1.Length; i++)
    {
        if (sb1[i] != sb2[i])
        {
            return false;
        }
    }
    return true;
}

string str1 = "Hester Mofet";
string str2 = "The Rest of Me";
string str3 = "Louis Friend";
string str4 = "Iron Sulfide";

Console.WriteLine();
Console.WriteLine($"'{str1}' and '{str2}' {(IsAnagram(str1, str2) ? "ARE" : "ARE NOT")} anagrams\n");

Console.WriteLine($"'{str3}' and '{str4}' {(IsAnagram(str1, str2) ? "ARE" : "ARE NOT")} anagrams\n");

Console.WriteLine("Now, can you name the movie these are referencing?\n");
