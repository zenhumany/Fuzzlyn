// Generated by Fuzzlyn on 2018-07-05 21:09:05
// Seed: 1040693641255943959
// Reduced from 32.2 KiB to 0.2 KiB
// Debug: Outputs 34495
// Release: Outputs 4294936255
public class Program
{
    static short[] s_1 = new short[]{-31043};
    public static void Main()
    {
        var vr21 = (char)(s_1[0] | 2U);
        uint vr22 = vr21;
        System.Console.WriteLine(vr22);
    }
}