// Generated by Fuzzlyn on 2018-06-29 01:42:34
// Seed: 601665821296274569
// Reduced from 140.5 KiB to 0.4 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static ushort[][, ] s_1 = new ushort[][, ]{new ushort[, ]{{0}}};
    public static void Main()
    {
        var vr8 = (short)(0 & s_1[0][0, 0]);
        var vr9 = s_1[0][0, 0];
        M6(vr8);
    }

    static ulong M6(short arg0)
    {
        int[] var0 = new int[]{0, 0, 0, 0, 0, 2147483647, 0, 0};
        return 0;
    }
}