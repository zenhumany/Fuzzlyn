// Generated by Fuzzlyn on 2018-06-24 20:53:41
// Seed: 12232326005673059621
// Reduced from 47.2 KiB to 0.2 KiB
// Debug: Outputs 63734
// Release: Outputs -1802
public class Program
{
    static short s_1 = -1802;
    public static void Main()
    {
        char vr5 = (char)(s_1 / (0U | 1));
        int vr3 = vr5;
        System.Console.WriteLine(vr3);
    }
}