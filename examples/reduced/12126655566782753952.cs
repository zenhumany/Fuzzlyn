// Generated by Fuzzlyn on 2018-06-22 13:38:22
// Seed: 12126655566782753952
// Reduced from 127.2 KiB to 0.2 KiB
// Debug: Outputs 65479
// Release: Outputs 4294967239
public class Program
{
    static long s_1;
    static sbyte s_2 = -57;
    public static void Main()
    {
        var vr19 = (char)((ushort)(0 ^ s_1) | s_2);
        uint vr20 = vr19;
        System.Console.WriteLine(vr20);
    }
}