//https://www.hackerrank.com/challenges/bon-appetit/

int[] item = Array.ConvertAll(Console.ReadLine().Split(' ').ToArray(), int.Parse);
int[] itemCost = Array.ConvertAll(Console.ReadLine().Split(' ').ToArray(), int.Parse);
int annaPay = Convert.ToInt32(Console.ReadLine());

itemCost[item[1]] = 0;

int actualPay = itemCost.Sum() / 2;
 

if(actualPay < annaPay)
{
    Console.WriteLine(annaPay-actualPay);
}
else
{
    Console.WriteLine("Bon Appetit");
}