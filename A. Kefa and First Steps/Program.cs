int n = int.Parse(Console.ReadLine());
int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int count  = 0;
int maxCount = 0;
for (int i = 0; i < input.Length -1; i++)
{
    if (input[i] <= input[i + 1])
    {
        count++;
    }

    else
    {
        if(count > maxCount)
        {
            maxCount = count;
        }
        count = 0;
    }
}

if  (count > maxCount)
    Console.WriteLine(count + 1);
else
    Console.WriteLine(maxCount + 1);