// Generated by Fuzzlyn v1.1 on 2018-08-02 22:01:47
// Seed: 13226477392513019204
// Reduced from 42.6 KiB to 0.7 KiB
// Debug: Prints 0 line(s)
// Release: Prints 1 line(s)
class C0
{
    public byte F1;
    public bool F2;
    public C0(bool f2)
    {
        F2 = f2;
    }
}

struct S0
{
    public C0 F0;
    public C0 F1;
    public S0(C0 f0, C0 f1): this()
    {
        F0 = f0;
        F1 = f1;
    }
}

public class Program
{
    static S0 s_4;
    static S0[] s_23 = new S0[]{new S0(new C0(true), new C0(false))};
    public static void Main()
    {
        M10() = s_23[0];
        bool vr8 = s_4.F0.F2;
        if (vr8)
        {
            byte vr9 = s_4.F1.F1;
            System.Console.WriteLine(vr9);
        }
    }

    static ref S0 M10()
    {
        s_23 = new S0[]{new S0(new C0(false), new C0(true))};
        return ref s_4;
    }
}
