// Generated by Fuzzlyn on 2018-07-08 16:39:35
// Seed: 14274351059245223072
// Reduced from 39.4 KiB to 0.4 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
class C0
{
    public int F1;
    public int F2;
    public ulong F3;
}

public class Program
{
    static C0[, ] s_4 = new C0[, ]{{new C0()}};
    public static void Main()
    {
        var vr2 = new C0();
        ushort vr3 = (ushort)((uint)((char)(0 * M1(vr2)) * s_4[0, 0].F3) / (s_4[0, 0].F1 | 1));
    }

    static sbyte M1(C0 arg0)
    {
        return (sbyte)arg0.F2;
    }
}