// Generated by Fuzzlyn on 2018-07-10 09:26:09
// Seed: 70792906314208454
// Reduced from 12.8 KiB to 0.2 KiB
// Debug: Outputs 251
// Release: Outputs -14389765
public class Program
{
    static sbyte s_1;
    public static void Main()
    {
        s_1 = -128;
        byte vr12 = (byte)(1813110492 / (2L - (uint)s_1));
        long vr9 = vr12;
        System.Console.WriteLine(vr9);
    }
}