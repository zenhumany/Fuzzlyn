// Generated by Fuzzlyn on 2018-06-22 12:49:29
// Seed: 2885832984055711928
// Reduced from 126.9 KiB to 0.5 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
class C0
{
    public byte F2;
}

struct S0
{
    public C0 F1;
    public S0(C0 f1): this()
    {
        F1 = f1;
    }
}

struct S2
{
    public long F6;
    public S2(long f6): this()
    {
        F6 = f6;
    }
}

public class Program
{
    static S2 s_2 = new S2(1L);
    static S0[,, ] s_14 = new S0[,, ]{{{new S0(new C0())}}};
    public static void Main()
    {
        long vr0 = (0 & s_14[0, 0, 0].F1.F2) / s_2.F6;
    }
}