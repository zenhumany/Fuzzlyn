// Generated by Fuzzlyn on 2018-07-08 09:37:30
// Seed: 16947959171633075400
// Reduced from 275.1 KiB to 0.7 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
class C0
{
    public int F9;
}

struct S0
{
    public C0 F0;
    public S0(C0 f0): this()
    {
        F0 = f0;
    }
}

struct S1
{
    public ulong F1;
    public S0 F3;
    public S1(S0 f3): this()
    {
        F3 = f3;
    }
}

class C1
{
    public ulong F0;
}

public class Program
{
    static C1 s_3 = new C1();
    static S1[, ] s_6 = new S1[, ]{{new S1(new S0(new C0()))}};
    public static void Main()
    {
        var vr65 = (sbyte)(0 & s_6[0, 0].F3.F0.F9);
        var vr66 = s_3.F0;
        var vr67 = s_6[0, 0].F1;
        M14(vr66, vr65);
    }

    static int M14(ulong arg0, sbyte arg3)
    {
        System.Console.WriteLine(arg0);
        return s_6[0, 0].F3.F0.F9;
    }
}