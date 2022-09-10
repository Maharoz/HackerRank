//https://www.hackerrank.com/challenges/breaking-best-and-worst-records/

int x = Convert.ToInt32(Console.ReadLine());
int[] y = Array.ConvertAll(Console.ReadLine().Split(' ').ToArray(), int.Parse);

int min = y[0];
int max = y[0];
int minBroked = 0;
int maxBroked = 0;

for (int i = 0; i < y.Length; i++)
{
    if (y[i] > max)
    {
        max = y[i];
        maxBroked++;
    }
    else if (y[i]<min)
    {
        min = y[i];
        minBroked++;
    }
}
Console.WriteLine(maxBroked+" "+minBroked);
