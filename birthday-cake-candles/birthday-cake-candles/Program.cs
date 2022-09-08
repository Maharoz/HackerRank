//https://www.hackerrank.com/challenges/birthday-cake-candles/
int x = Convert.ToInt32(Console.ReadLine());
int[] ar = Array.ConvertAll(Console.ReadLine().Split(' ').ToArray(), int.Parse);
int max = ar[0];
var occurrenceCount = 1;

for (var i = 1; i < ar.Length; i++)
{
    if (ar[i] > max)
    {
        max = ar[i];
        occurrenceCount = 1;
    }
    else if (ar[i] == max)
    {
        occurrenceCount++;
    }
}

Console.WriteLine(occurrenceCount);