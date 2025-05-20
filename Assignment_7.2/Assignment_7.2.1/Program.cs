/*

1. Listen (and ask questions),
2. Generate Examples (that cover all pertinent cases and corner cases),
3. Brute Force (pseudo),
4. Optimize,
5. Walk Through,
6. Test,
7. Implement (code),
8. Test Again

Shell sorting is

*/

static void ShellSort(int[] arr)
{
    int arrLength = arr.Length;
    for (int gap = arrLength / 2; gap > 0; gap /= 2)
    {
        for (int i = gap; i < arrLength; i++)
        {
            int temp = arr[i];
            int j;
            for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
            {
                arr[j] = arr[j - gap];
            }
            arr[j] = temp;
        }
    }
}
Console.WriteLine("Enter numbers separated by spaces:");
string? userInputArray = Console.ReadLine();
Console.WriteLine();
if (string.IsNullOrWhiteSpace(userInputArray))
{
    Console.WriteLine("No input provided. Exiting.");
    return;
}
int[] numbers = Array.ConvertAll(
    userInputArray.Split(' ', StringSplitOptions.RemoveEmptyEntries),
    int.Parse //this witchcraft was auto filled and looks pretty cool so I'm gonna use it here
);

ShellSort(numbers);

Console.WriteLine("Sorted Array:");
Console.WriteLine(string.Join(" ", numbers));
Console.WriteLine();
