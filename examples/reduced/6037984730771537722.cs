// Generated by Fuzzlyn on 2018-07-18 06:28:09
// Seed: 6037984730771537722
// Reduced from 35.8 KiB to 0.3 KiB
// Debug: Outputs 65457
// Release: Outputs -79
public class Program
{
    static sbyte s_1;
    public static void Main()
    {
        byte vr11 = 0;
        s_1 = (sbyte)((vr11 | 1) * -1359922255);
        char vr15 = (char)(-9223372036854775808L ^ s_1);
        System.Console.WriteLine((int)vr15);
    }
}