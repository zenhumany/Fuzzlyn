// Generated by Fuzzlyn on 2018-07-05 14:57:22
// Seed: 14101041769027653231
// Reduced from 42.5 KiB to 0.2 KiB
// Debug: Outputs -109
// Release: Outputs -11117
public class Program
{
    static short[] s_3;
    public static void Main()
    {
        s_3 = new short[]{-11117};
        int vr15 = s_3[0] | (sbyte)s_3[0];
        System.Console.WriteLine(vr15);
    }
}