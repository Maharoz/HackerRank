//https://www.hackerrank.com/challenges/migratory-birds/

using System.Linq;
var a = Console.ReadLine();
var ar_temp = Console.ReadLine().Split(' ');
var ar = Array.ConvertAll(ar_temp, int.Parse);
var result = MigratoryBirds(ar);
Console.WriteLine(result);

static int MigratoryBirds(int[] ar)
{
    var birdTypeCounts = new int[5];

    for (int i = 0; i < ar.Length; i++)
        birdTypeCounts[ar[i] - 1]++;

    var maxBirdTypeCount = birdTypeCounts[0];
    var maxBirdType = 1;

    for (int i = 1; i < 5; i++)
    {
        if (birdTypeCounts[i] > maxBirdTypeCount)
        {
            maxBirdTypeCount = birdTypeCounts[i];
            maxBirdType = i + 1;
        }

        if (birdTypeCounts[i] == maxBirdTypeCount && i + 1 < maxBirdType)
            maxBirdType = i + 1;
    }

    return maxBirdType;
}