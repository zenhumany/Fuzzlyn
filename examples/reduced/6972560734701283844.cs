// Generated by Fuzzlyn on 2018-07-07 23:40:02
// Seed: 6972560734701283844
// Reduced from 83.4 KiB to 0.4 KiB
// Debug: Outputs 65410
// Release: Outputs 4294967170
class C0
{
    public sbyte F0;
    public C0(sbyte f0)
    {
        F0 = f0;
    }
}

public class Program
{
    static C0[] s_11;
    static byte[,, ] s_18 = new byte[,, ]{{{0}}};
    public static void Main()
    {
        s_11 = new C0[]{new C0(-126)};
        var vr18 = (ushort)(s_18[0, 0, 0] | s_11[0].F0);
        ulong vr19 = vr18;
        System.Console.WriteLine(vr19);
    }
}