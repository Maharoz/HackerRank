//https://www.hackerrank.com/challenges/kangaroo/

int[] input = Array.ConvertAll(Console.ReadLine().Split(' ').ToArray(), int.Parse);
int x1 = input[0];
int v1 = input[1];
int x2 = input[2];
int v2 = input[3];

if(x2>x1 && v2 > v1)
{
    Console.WriteLine("NO");
}else if(x1 > x2 && v1 > v2)
{
    Console.WriteLine("NO");
}else if(x1 == x2 && (v2 > v1|| v1 > v2))
{
    Console.WriteLine("NO");
}
else
{
    if ((x2 - x1) % (v2 - v1) == 0)
    {
        Console.WriteLine("YES");
    }
    else {
        Console.WriteLine("NO");
            }
}