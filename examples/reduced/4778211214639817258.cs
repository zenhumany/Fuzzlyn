// Generated by Fuzzlyn on 2018-06-27 19:26:21
// Seed: 4778211214639817258
// Reduced from 18.3 KiB to 0.2 KiB
// Debug: Outputs 65408
// Release: Outputs -128
public class Program
{
    static sbyte s_3;
    public static void Main()
    {
        s_3 = -127;
        char vr19 = (char)(int)(s_3 ^ 1U);
        System.Console.WriteLine((int)vr19);
    }
}