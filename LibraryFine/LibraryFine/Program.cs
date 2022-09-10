// https://www.hackerrank.com/challenges/library-fine/
int[] returnDate = Array.ConvertAll(Console.ReadLine().Split(' ').ToArray(), int.Parse);
int[] issueDate = Array.ConvertAll(Console.ReadLine().Split(' ').ToArray(), int.Parse);

int result = 0;
if (returnDate[0] > issueDate[0] &&
    returnDate[1] == issueDate[1] &&
    returnDate[2] == issueDate[2])
{
    result = (returnDate[0] - issueDate[0]) * 15;
}
else if (
    returnDate[1] > issueDate[1] &&
    returnDate[2] == issueDate[2])
{
    result = (returnDate[1] - issueDate[1]) * 500;
}

else if (
    returnDate[2] > issueDate[2])
{
    result = 10000;
}

Console.WriteLine(result);