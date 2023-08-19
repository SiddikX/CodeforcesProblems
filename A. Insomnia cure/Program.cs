int k = int.Parse(Console.ReadLine());
int l = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int d = int.Parse(Console.ReadLine());

//HashSet<int> s = new HashSet<int>();
int count = 0;
for(int i = 1; i <= d; i++)
{
    if (i % k == 0 || i % l == 0 || i % m == 0 || i % n == 0)
        count++;

    /*if(i*k <= d)
        s.Add(i*k);
    if(i*l <= d)
        s.Add(i*l);
    if(i*m <= d)
        s.Add(i*m);
    if(i*n <= d)
        s.Add(i*n);*/
}
Console.WriteLine(count);