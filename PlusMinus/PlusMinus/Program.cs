//https://www.hackerrank.com/challenges/plus-minus/
int n = Convert.ToInt32(Console.ReadLine());

int[] input = Array.ConvertAll(Console.ReadLine().Split(' ').ToArray(), int.Parse);

double positiveNumbers = (double)input.Where(x => x > 0).Count()/input.Length;

Console.WriteLine(positiveNumbers.ToString("N6"));
double negativeNumbers = (double)input.Where(x => x < 0).Count() / input.Length;

Console.WriteLine(negativeNumbers.ToString("N6"));
double neutralNumbers = (double)input.Where(x => x == 0).Count() / input.Length;

Console.WriteLine(neutralNumbers.ToString("N6"));