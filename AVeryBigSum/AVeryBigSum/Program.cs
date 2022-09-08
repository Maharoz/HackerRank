//https://www.hackerrank.com/challenges/a-very-big-sum/

int n = Convert.ToInt32(Console.ReadLine());
long[] m = Array.ConvertAll(Console.ReadLine().Split(' ').ToArray(), long.Parse);

long result = 0;
for (int i = 0; i < n; i++)
{
    result += m[i];
}

Console.WriteLine(result);