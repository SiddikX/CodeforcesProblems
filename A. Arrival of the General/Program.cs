int n = int.Parse(Console.ReadLine());
int[] ints = Console.ReadLine().Split().Select(int.Parse).ToArray();
int countMax = 0;
int countMin = n-1;

while (ints[countMax] != ints.Max())
{
    countMax++;
}

while (ints[countMin] != ints.Min())
{
    countMin--;
}

int result = (countMax - 1) + (n - countMin);

if(countMax>countMin)
    Console.WriteLine(result -1);
else
    Console.WriteLine(result);