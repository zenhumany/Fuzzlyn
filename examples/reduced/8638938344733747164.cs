// Generated by Fuzzlyn on 2018-07-26 03:44:32
// Seed: 8638938344733747164
// Reduced from 13.2 KiB to 0.2 KiB
// Debug: Outputs 5579
// Release: Outputs 60107
public class Program
{
    static sbyte[] s_6 = new sbyte[]{-128};
    public static void Main()
    {
        char vr3 = (char)(7474325319740036427UL ^ (uint)s_6[0]);
        var vr4 = s_6[0];
        System.Console.WriteLine((int)vr3);
    }
}