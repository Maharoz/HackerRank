//https://www.hackerrank.com/challenges/diagonal-difference/
int n = Convert.ToInt32(Console.ReadLine());

int[,] x = new int[n, n];

int rightToLeft = 0;
int leftToRight = 0;

for(int i = 0; i < n; i++)
{
    int[] arr = Array.ConvertAll(Console.ReadLine().Split(' ').ToArray(), int.Parse);

    for(int j = 0; j < arr.Length; j++)
    {
        x[i, j] = arr[j];
    }
    //x[i,0]=arr[0];
    //x[i,1]=arr[1];
    //x[i,2]=arr[2];

}
int m = n-1;
for(int i = 0; i < n; i++)
{
    rightToLeft += x[i, i];
}

for (int i = 0; i < n; i++)
{
    leftToRight += x[i, m];
    m--;
}

int result = rightToLeft - leftToRight;
Console.WriteLine(Math.Abs(result));