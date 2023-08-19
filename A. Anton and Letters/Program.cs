var input = Console.ReadLine();
var hs = new HashSet<char>();
for (int i = 1; i < input.Length -1; i++)
{
    if (input[i] != ' ' && input[i] != ',')
        hs.Add(input[i]);
}
Console.WriteLine(hs.Count());