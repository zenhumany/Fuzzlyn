// Generated by Fuzzlyn on 2018-06-25 11:45:13
// Seed: 3988693532915749522
// Reduced from 36.3 KiB to 0.2 KiB
// Debug: Outputs 65409
// Release: Outputs -127
public class Program
{
    static sbyte s_3 = -127;
    static byte s_4;
    public static void Main()
    {
        byte vr35 = s_4;
        var vr30 = (char)(vr35 | s_3);
        System.Console.WriteLine((int)vr30);
    }
}