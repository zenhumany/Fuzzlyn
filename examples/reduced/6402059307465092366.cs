// Generated by Fuzzlyn on 2018-06-19 04:18:34
// Seed: 6402059307465092366
// Reduced from 39.1 KiB to 0.2 KiB
// Debug: Outputs 65485
// Release: Outputs -51
public class Program
{
    static int s_2;
    static int s_3;
    static sbyte s_4;
    public static void Main()
    {
        s_4 = -51;
        s_2 = (char)((int)(0 & (long)s_3) ^ s_4);
        System.Console.WriteLine(s_2);
    }
}
