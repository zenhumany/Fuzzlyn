// Generated by Fuzzlyn on 2018-06-19 20:36:59
// Seed: 9613570339117363693
// Reduced from 445.2 KiB to 0.5 KiB
// Debug: Outputs False
// Release: Outputs True
struct S0
{
    public ushort F0;
    public S0(ushort f0): this()
    {
    }
}

struct S1
{
    public S0 F1;
    public bool F2;
}

class C1
{
    public S1 F9;
}

class C2
{
    public C1 F3;
    public C2(C1 f3)
    {
        F3 = f3;
    }
}

public class Program
{
    static C2 s_17 = new C2(new C1());
    public static void Main()
    {
        s_17.F3.F9.F1 = M31();
        System.Console.WriteLine(s_17.F3.F9.F2);
    }

    static S0 M31()
    {
        return new S0(0);
    }
}
