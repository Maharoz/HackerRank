//https://www.hackerrank.com/challenges/apple-and-orange/

int[] home = Array.ConvertAll(Console.ReadLine().Split(' ').ToArray(),int.Parse);
int[] tree = Array.ConvertAll(Console.ReadLine().Split(' ').ToArray(), int.Parse);
int[] fruitCount = Array.ConvertAll(Console.ReadLine().Split(' ').ToArray(), int.Parse);

int[] applePlot = Array.ConvertAll(Console.ReadLine().Split(' ').ToArray(), int.Parse);
int[] orangePlot = Array.ConvertAll(Console.ReadLine().Split(' ').ToArray(), int.Parse);

int inHomeAppleCount = 0;
int inHomeOrangeCount = 0;


for (int i=0;i<applePlot.Length; i++)
{
    applePlot[i]= applePlot[i] +tree[0];
    if (applePlot[i]>=home[0] && applePlot[i] <= home[1])
    {
        inHomeAppleCount++;
    }
}

for (int i= 0; i < orangePlot.Length; i++)
{
    orangePlot[i] = orangePlot[i] + tree[1];
    if (orangePlot[i] >= home[0] && orangePlot[i] <= home[1])
    {
        inHomeOrangeCount++;
    }
}


Console.WriteLine(inHomeAppleCount);
Console.WriteLine(inHomeOrangeCount);
    