// Generated by Fuzzlyn on 2018-06-19 22:01:26
// Seed: 14636603346434300967
// Reduced from 79.7 KiB to 0.2 KiB
// Debug: Outputs 65535
// Release: Outputs -1
public class Program
{
    static short s_2 = -1;
    static int s_4;
    public static void Main()
    {
        s_4 = (ushort)(s_2 | 0U);
        System.Console.WriteLine(s_4);
    }
}
