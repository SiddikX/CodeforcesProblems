int n = int.Parse(Console.ReadLine());
string ns = n.ToString();
string res = "";
for (int i = n+1; i > n; i++)
{
    res = i.ToString();
    if (res.Distinct().Count() == ns.Length)
    {
        break;
    }
}
Console.WriteLine(res);