// Generated by Fuzzlyn on 2018-07-21 11:06:19
// Seed: 11098790323166064902
// Reduced from 12.6 KiB to 0.3 KiB
// Debug: Outputs 255
// Release: Outputs 65535
public class Program
{
    static byte s_1;
    public static void Main()
    {
        byte[] vr0 = new byte[]{0};
        s_1 = 255;
        vr0[0] = s_1;
        ushort vr1 = (ushort)(vr0[0] % (short)((short)((s_1 | 18446744073709551615UL) + 2467771019U) | 1));
        System.Console.WriteLine(vr1);
    }
}