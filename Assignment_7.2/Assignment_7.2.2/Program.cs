/*

1. Listen (and ask questions),
2. Generate Examples (that cover all pertinent cases and corner cases),
3. Brute Force (pseudo),
4. Optimize,
5. Walk Through,
6. Test,
7. Implement (code),
8. Test Again

Take a string and get all the vowels in it.
reverse ONLY the vowels.
return the new string

ABCDE -> EBCDA
AEIOU -> UOIEA
HELLO -> HOLLE

Option 1 use string builder
bool isVowel(char c)
if c == a || c == e || c == i || c == o || c == u 
then isVowel = true

left pointer = 0
right pointer = string.length - 1
append sb with non vowels
outer loop for left pointer stop at vowel
inner loop for right pointer stop at vowel
swap vowels
temp = sb[i]
sb[i] = sb[right pointer]
sb[right pointer] = temp
right pointer--
add non vowels to sb
return sb.ToString()

Option 2 use char array
parse string into char array
loop through char array
2 pointers
left pointer = 0
right pointer = string.length - 1
while left pointer < right pointer
if char[left pointer] & char[right pointer] are vowels
then swap with vowel char at right pointer
char[left pointer] = char[right pointer]
char[right pointer] = temp
left pointer++
right pointer--
return char array and convert back to string

*/

using System.Text;

bool isVowel(char c)
{
    
    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
    {
        return true;
    }
    else
    {
        return false;
    }
}

string ReverseVowels(string inputString)
{
    // Option 2
    char[] chars = inputString.ToCharArray();
    int leftPointer = 0;
    int rightPointer = chars.Length - 1;

    while (leftPointer < rightPointer)
    {
        if (!isVowel(chars[leftPointer]))
        {
            leftPointer++; //Only increment if it's not a vowel'
            continue;
        }
        if (!isVowel(chars[rightPointer]))
        {
            rightPointer--;
            continue;
        }

        char temp = chars[leftPointer]; //Swap vowels when both pointers are vowels
        chars[leftPointer] = chars[rightPointer];
        chars[rightPointer] = temp;

        leftPointer++;
        rightPointer--;
    }

    return new string(chars);
}
string inputString = "Hilla There! Huw ore YAo, Deepole?\n";

Console.WriteLine();
Console.WriteLine($"The input string of: \n{inputString}\n");
Console.WriteLine($"Becomes: \n{ReverseVowels(inputString)}");