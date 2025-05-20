/*
1. Listen (and ask questions) - it's written out for assignments
2. Generate Examples (that cover all pertinent cases and corner cases),
3. Brute Force (pseudo),
4. Optimize,
5. Walk Through,
6. Test,
7. Implement (code),
8. Test Again
*/

/*

1. You will get a list of scores and you need to sort them in ascending order.
 - are we dealing with whole numbers only or floating point numbers
 - is 100 the highest score?
 - do we need to output the sorted list and do we need to format the scores (back into percents?)
 
 2. 1, 4, 2, 3 ---> 1, 2, 3, 4
 
 3. Selection Sort algo is required. We'll use an array as the input.
 int[] inputScores = {x, y, z, ...}
 int arrayLength = inputScores.Length;
 
 iterate through the array and find the minimum value in the array.
 place the minimum value at the beginning of the array.
 move index to the next position and repeat the process.
 
 pointer to stay at the current position for comparison.
 
 outer loop: for (int i = 0; i < arrayLength - 1; i++) pointer for current minimum index 
 int indexForMinValue
 inner loop for (int j = i + 1; j < arrayLength; j++) compare the current value with the minimum value
 swap the values if the current value is less than the minimum value
 temp var to hold value at index i
 index i = indexForMinValue
 3 Card monte to swap the values
  

 */


int[] scoresArray = { 85, 92, 78, 90, 66, 100, 74 };
int scoresArrayLength = scoresArray.Length;

int[] SortScores(int[] scoresArray)
{
    for (int i = 0; i < scoresArrayLength - 1; i++)//goes to n-2 to avoid OOB error in inner loop
    {
        int minIndex = i; //index of the minimum value
        for (int j = i + 1; j < scoresArrayLength; j++) //goes to n-1 to avoid OOB error. last digit will sort itself.
        {
            if (scoresArray[j] < scoresArray[minIndex]) //compare i with the value in the minIndex
            {
                minIndex = j; //assign j to minIndex if j is less than i
            }
        }
        // Swap
        int temp = scoresArray[i]; //pull out the value at index i and store it in temp
        scoresArray[i] = scoresArray[minIndex]; //value at index i is now the value at minIndex (smallest remaining value)
        scoresArray[minIndex] = temp; // place the temp value (pulled earlier) in the spot we pulled the smallest remaining value from
    }
    return scoresArray;
}
Console.WriteLine($"Sorted Scores:\n{string.Join(", ",SortScores(scoresArray))}");