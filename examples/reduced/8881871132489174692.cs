// Generated by Fuzzlyn on 2018-06-24 01:06:49
// Seed: 8881871132489174692
// Reduced from 63.5 KiB to 0.2 KiB
// Debug: Outputs 223
// Release: Outputs 4294967263
public class Program
{
    static sbyte s_2 = -33;
    static long s_3;
    public static void Main()
    {
        s_3 = (byte)(0U ^ s_2);
        System.Console.WriteLine(s_3);
    }
}