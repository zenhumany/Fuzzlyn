// Generated by Fuzzlyn on 2018-07-14 00:49:16
// Seed: 14823260718330170646
// Reduced from 75.0 KiB to 0.4 KiB
// Debug: Outputs -15825
// Release: Outputs -3793
public class Program
{
    public static void Main()
    {
        byte[] vr23 = new byte[]{255};
        ulong[] vr24 = new ulong[]{0};
        short vr26 = (short)((vr23[0] / -1) * M20(vr24));
        System.Console.WriteLine(vr26);
    }

    static uint M20(ulong[] arg0)
    {
        System.Console.WriteLine(arg0[0]);
        return 1662775599U;
    }
}