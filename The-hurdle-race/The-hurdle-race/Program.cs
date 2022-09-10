//https://www.hackerrank.com/challenges/the-hurdle-race/
int[] input = Array.ConvertAll(Console.ReadLine().Split(' ').ToArray(), int.Parse);
int[] hurdles = Array.ConvertAll(Console.ReadLine().Split(' ').ToArray(), int.Parse);

int maxHurdle = hurdles.Max();

if(maxHurdle> input[1])
{
    Console.WriteLine(maxHurdle - input[1]);
}
else
{
    Console.WriteLine(0);
}
