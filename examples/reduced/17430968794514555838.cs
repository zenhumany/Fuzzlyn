// Generated by Fuzzlyn on 2018-07-06 09:39:29
// Seed: 17430968794514555838
// Reduced from 70.6 KiB to 0.7 KiB
// Debug: Outputs 65502
// Release: Outputs 4294967262
class C0
{
    public sbyte F1;
    public uint F3;
    public C0(sbyte f1)
    {
        F1 = f1;
    }
}

struct S0
{
    public C0 F4;
    public C0 F5;
    public C0 F6;
    public S0(C0 f4, C0 f5, C0 f6): this()
    {
        F4 = f4;
        F5 = f5;
        F6 = f6;
    }
}

public class Program
{
    static S0[] s_4 = new S0[]{new S0(new C0(0), new C0(0), new C0(-34))};
    static S0 s_5;
    public static void Main()
    {
        s_5 = s_4[0];
        short vr9 = default(short);
        s_5.F5.F1 = s_5.F6.F1;
        ushort vr10 = (ushort)(vr9 ^ s_4[0].F5.F1);
        s_4[0].F4.F3 = vr10;
        System.Console.WriteLine(s_5.F4.F3);
    }
}
