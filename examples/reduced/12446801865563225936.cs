// Generated by Fuzzlyn on 2018-07-05 20:41:35
// Seed: 12446801865563225936
// Reduced from 113.3 KiB to 0.3 KiB
// Debug: Outputs 98
// Release: Outputs 4294967138
class C0
{
    public sbyte F3;
    public C0(sbyte f3)
    {
        F3 = f3;
    }
}

public class Program
{
    static long s_9;
    static C0 s_14 = new C0(-79);
    public static void Main()
    {
        s_9 = s_14.F3 + (uint)s_14.F3;
        System.Console.WriteLine(s_9);
    }
}