//https://www.hackerrank.com/challenges/between-two-sets/

int[] ic = Array.ConvertAll(Console.ReadLine().Split(' ').ToArray(), int.Parse);

int[] a= Array.ConvertAll(Console.ReadLine().Split(' ').ToArray(), int.Parse);
int[] b = Array.ConvertAll(Console.ReadLine().Split(' ').ToArray(), int.Parse);

int r = getTotalX(a, b);
Console.WriteLine(r);

int getGCD(int n1,int n2)
{
    if(n2==0) return n1;

    return getGCD(n2, n1 % n2);

}


int getLCM(int n1, int n2)
{
    if (n1 == 0 || n2==0) return 0;

    else
    {
        int gcd=getGCD(n1,n2);
        return Math.Abs(n1 * n2) / gcd;
    }

}
 int getTotalX(int[] a , int[] b){
    int result = 0;
    int lcm = a[0];

    foreach(int i in a)
    {
        lcm=getLCM(lcm,i);
    }

    int gcd = b[0];

    foreach (int i in b)
    {
        gcd = getGCD(gcd, i);
    }

    int multiple = 0;
    while (multiple <= gcd)
    {
        multiple += lcm;

        if (gcd % multiple == 0)
            result++;
    }

    return result;
}
