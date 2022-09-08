//https://www.hackerrank.com/challenges/staircase/

int n = Convert.ToInt32(Console.ReadLine());



for(int i = 1; i <= n; i++)
{
    Console.WriteLine(new String(' ', n-i)+new string('#',i));
}
