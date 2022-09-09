// https://www.hackerrank.com/challenges/

int tc = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[tc];

for(int i =0;i< tc; i++)
{
    arr[i]= Convert.ToInt32(Console.ReadLine());
}

for(int i = 0;i< arr.Length; i++)
{
    if (arr[i]>37 && arr[i] % 5 > 2 )
    {
        arr[i] = arr[i] + (5-(arr[i] % 5));
    }
}

foreach(int i in arr)
{
    Console.WriteLine(i);
}