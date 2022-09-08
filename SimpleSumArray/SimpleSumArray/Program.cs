//https://www.hackerrank.com/challenges/simple-array-sum/problem
int n = Convert.ToInt32(Console.ReadLine());

string s = Console.ReadLine();

string[] a = s.Split(' ').ToArray();

int[] inputArr = Array.ConvertAll(a, int.Parse);

int result = 0;

foreach (int a2 in inputArr)
{
    result += a2;
}
Console.WriteLine(result);
