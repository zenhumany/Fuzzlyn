// Generated by Fuzzlyn on 2018-06-29 17:59:29
// Seed: 3572364903172879350
// Reduced from 63.3 KiB to 0.2 KiB
// Debug: Outputs 65511
// Release: Outputs 4294967271
public class Program
{
    static short s_2;
    static sbyte s_5 = -25;
    public static void Main()
    {
        char vr11 = (char)((char)(1U & s_2) | s_5);
        ulong vr8 = vr11;
        System.Console.WriteLine(vr8);
    }
}