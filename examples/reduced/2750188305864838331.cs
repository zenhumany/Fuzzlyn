// Generated by Fuzzlyn on 2018-07-11 03:56:22
// Seed: 2750188305864838331
// Reduced from 31.0 KiB to 0.2 KiB
// Debug: Throws 'System.OverflowException'
// Release: Runs successfully
public class Program
{
    static sbyte s_2;
    public static void Main()
    {
        bool vr26 = 0 < s_2--;
        var vr29 = 0 & (-9223372036854775808L % s_2);
        System.Console.WriteLine(vr29);
    }
}
