// Generated by Fuzzlyn on 2018-06-20 15:30:51
// Seed: 14551236707678757509
// Reduced from 101.5 KiB to 0.2 KiB
// Debug: Outputs 254
// Release: Outputs 4294967294
public class Program
{
    static sbyte s_4 = -2;
    public static void Main()
    {
        byte vr38 = (byte)(s_4 / (uint)1);
        ulong vr30 = vr38;
        System.Console.WriteLine(vr30);
    }
}