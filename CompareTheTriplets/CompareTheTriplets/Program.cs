string aliceInput = Console.ReadLine();
string bonInput = Console.ReadLine();

int[] aliceArray = Array.ConvertAll(aliceInput.Split(' ').ToArray(), int.Parse);
int[] bobArray = Array.ConvertAll(bonInput.Split(' ').ToArray(), int.Parse);

int ptsForAlice = 0;
int ptsForBob = 0;


for(int i = 0; i < aliceArray.Length; i++)
{
    if(aliceArray[i] > bobArray[i])
    {
        ptsForAlice += 1;
    }
    else if(aliceArray[i] < bobArray[i])
    {
        ptsForBob += 1;
    }
}

int[] res = { ptsForAlice, ptsForBob };

Console.WriteLine(res[0]+" "+ res[1]);

