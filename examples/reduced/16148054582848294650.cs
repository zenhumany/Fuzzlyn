// Generated by Fuzzlyn on 2018-06-23 17:48:53
// Seed: 16148054582848294650
// Reduced from 0.8 KiB to 0.2 KiB
// Debug: Outputs 65535
// Release: Outputs 4294967295
public class Program
{
    static ulong s_1;
    public static void Main()
    {
        --s_1;
        s_1 &= (ushort)(sbyte)(s_1 | 1);
        System.Console.WriteLine(s_1);
    }
}