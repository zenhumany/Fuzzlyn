// Generated by Fuzzlyn on 2018-07-10 11:16:27
// Seed: 13543674716925107914
// Reduced from 461.9 KiB to 0.5 KiB
// Debug: Outputs 65436
// Release: Outputs -100
class C2
{
    public sbyte F7;
    public C2(sbyte f7)
    {
        F7 = f7;
    }
}

class C3
{
    public C2 F2;
    public C3(C2 f2)
    {
        F2 = f2;
    }
}

public class Program
{
    static C3 s_1 = new C3(new C2(-100));
    static ushort[] s_5 = new ushort[]{0};
    public static void Main()
    {
        char vr22 = (char)M25();
        System.Console.WriteLine((int)vr22);
    }

    static ushort M25()
    {
        return (ushort)(s_5[0] ^ s_1.F2.F7);
    }
}