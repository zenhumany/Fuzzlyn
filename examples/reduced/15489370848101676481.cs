// Generated by Fuzzlyn on 2018-07-01 08:24:45
// Seed: 15489370848101676481
// Reduced from 46.4 KiB to 0.2 KiB
// Debug: Outputs 65456
// Release: Outputs -80
public class Program
{
    static ulong s_2 = 11971324980758955696UL;
    public static void Main()
    {
        char vr4 = (char)(sbyte)(s_2 / 1U);
        System.Console.WriteLine((int)vr4);
    }
}