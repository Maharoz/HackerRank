//https://www.hackerrank.com/challenges/sock-merchant/
int x = Convert.ToInt32(Console.ReadLine());
int pairCount = 0;
int[] arr1 = Array.ConvertAll(Console.ReadLine().Split(' ').ToArray(), int.Parse);
var groups = arr1.GroupBy(item => item);
foreach (var group in groups)
{
    if (group.Count()>1 && group.Count() % 2 == 0)
    {
        int n = group.Count() / 2;
        pairCount= pairCount + n;
    }
    else if(group.Count() > 1 && group.Count() % 2 != 0)
    {
        int n = (group.Count() - 1)/2;
        pairCount = pairCount + n;
    }
}

Console.WriteLine(pairCount);