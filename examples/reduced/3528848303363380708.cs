// Generated by Fuzzlyn on 2018-07-01 04:20:35
// Seed: 3528848303363380708
// Reduced from 51.2 KiB to 0.2 KiB
// Debug: Outputs 65424
// Release: Outputs -112
public class Program
{
    static sbyte s_3 = -112;
    public static void Main()
    {
        short vr11 = 0;
        char vr12 = (char)(s_3 ^ vr11);
        System.Console.WriteLine((int)vr12);
    }
}