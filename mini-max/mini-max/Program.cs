//https://www.hackerrank.com/challenges/mini-max-sum/

string s = Console.ReadLine();
long[] x = Array.ConvertAll(s.Split(' '), long.Parse);

List<long> maxLst = x.OfType<long>().ToList();
List<long> minLst = x.OfType<long>().ToList();

long max = x.Max();
long min = x.Min();

maxLst.Remove(min);
minLst.Remove(max);

long maxtotal = maxLst.Sum(x => Convert.ToInt64(x));
long mintotal = minLst.Sum(x => Convert.ToInt64(x));
Console.WriteLine( mintotal+ " " + maxtotal);