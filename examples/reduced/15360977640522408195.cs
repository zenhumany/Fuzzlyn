// Generated by Fuzzlyn on 2018-06-24 19:23:02
// Seed: 15360977640522408195
// Reduced from 11.4 KiB to 0.4 KiB
// Debug: Throws 'System.OverflowException'
// Release: Runs successfully
struct S0
{
    public char F2;
    public sbyte F5;
    public long F6;
}

public class Program
{
    public static void Main()
    {
        var vr13 = new S0();
        var vr14 = new S0();
        ulong vr12 = (ulong)((-9223372036854775808L % (M4(vr13, vr14) | 1)) & 0);
        System.Console.WriteLine(vr12);
    }

    static int M4(S0 arg1, S0 arg2)
    {
        arg1.F2 = (char)(arg2.F5 - arg1.F6);
        return -2;
    }
}