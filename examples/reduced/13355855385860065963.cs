// Generated by Fuzzlyn on 2018-07-27 11:41:31
// Seed: 13355855385860065963
// Reduced from 286.6 KiB to 0.3 KiB
// Debug: Throws 'System.OverflowException'
// Release: Runs successfully
public class Program
{
    static int s_3;
    static sbyte s_7;
    public static void Main()
    {
        s_3 = -2147483647;
        int vr21 = s_3--;
        M7(-1, s_7);
    }

    static ushort M7(short arg2, sbyte arg3)
    {
        return (ushort)((sbyte)(0 & (byte)(s_3 % (arg2 | 0))) ^ arg3);
    }
}