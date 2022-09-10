// https://www.hackerrank.com/challenges/magic-square-forming/

int[] a = Array.ConvertAll(Console.ReadLine().Split(' ').ToArray(), int.Parse);
int[] b = Array.ConvertAll(Console.ReadLine().Split(' ').ToArray(), int.Parse);
int[] c = Array.ConvertAll(Console.ReadLine().Split(' ').ToArray(), int.Parse);


var z = new int[a.Length + b.Length +c.Length];
a.CopyTo(z, 0);
b.CopyTo(z, a.Length);
c.CopyTo(z, a.Length+b.Length);

List<List<int>> list = new List<List<int>>();

List<int> list2 = new List<int>();

list2.Add(8);
list2.Add(1);
list2.Add(6);

list2.Add(3);
list2.Add(5);
list2.Add(7);

list2.Add(4);
list2.Add(9);
list2.Add(2);

list.Add(list2);

list2 = new List<int>();

list2.Add(6);
list2.Add(1);
list2.Add(8);

list2.Add(7);
list2.Add(5);
list2.Add(3);

list2.Add(2);
list2.Add(9);
list2.Add(4);
list.Add(list2);

list2 = new List<int>();

list2.Add(4);
list2.Add(9);
list2.Add(2);

list2.Add(3);
list2.Add(5);
list2.Add(7);

list2.Add(8);
list2.Add(1);
list2.Add(6);

list.Add(list2);

list2 = new List<int>();

list2.Add(2);
list2.Add(9);
list2.Add(4);

list2.Add(7);
list2.Add(5);
list2.Add(3);


list2.Add(6);
list2.Add(1);
list2.Add(8);

list.Add(list2);

list2 = new List<int>();

list2.Add(8);
list2.Add(3);
list2.Add(4);

list2.Add(1);
list2.Add(5);
list2.Add(9);


list2.Add(6);
list2.Add(7);
list2.Add(2);

list.Add(list2);

list2 = new List<int>();

list2.Add(4);
list2.Add(3);
list2.Add(8);


list2.Add(9);
list2.Add(5);
list2.Add(1);

list2.Add(2);
list2.Add(7);
list2.Add(6);

list.Add(list2);


list2 = new List<int>();

list2.Add(6);
list2.Add(7);
list2.Add(2);

list2.Add(1);
list2.Add(5);
list2.Add(9);

list2.Add(8);
list2.Add(3);
list2.Add(4);

list.Add(list2);


list2 = new List<int>();

list2.Add(2);
list2.Add(7);
list2.Add(6);

list2.Add(9);
list2.Add(5);
list2.Add(1);

list2.Add(4);
list2.Add(3);
list2.Add(8);

list.Add(list2);

int minCost = int.MaxValue;

foreach (List<int> i in list)
{
    int latestMinCost = 0;
    int k = 0;
   foreach (int j in i)
    {

        if (j != z[k])
        {
            latestMinCost = latestMinCost + Math.Abs(j - z[k]);
        } ;
        k++;
    }
    minCost=Math.Min(minCost, latestMinCost);
}

Console.WriteLine(minCost);


