// Generated by Fuzzlyn on 2018-07-28 05:48:46
// Seed: 5582776407432448710
// Reduced from 132.3 KiB to 0.3 KiB
// Debug: Outputs 65535
// Release: Outputs -1
class C0
{
    public sbyte F1;
    public C0(sbyte f1)
    {
        F1 = f1;
    }
}

public class Program
{
    public static void Main()
    {
        var vr16 = new C0(-1);
        char vr20 = (char)(vr16.F1 | 1L);
        System.Console.WriteLine((int)vr20);
    }
}