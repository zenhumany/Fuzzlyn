// Generated by Fuzzlyn on 2018-07-11 08:42:03
// Seed: 8677179058612737190
// Reduced from 12.8 KiB to 0.2 KiB
// Debug: Outputs 65535
// Release: Outputs -1
public class Program
{
    static short s_1;
    public static void Main()
    {
        short vr17 = s_1--;
        var vr21 = (ushort)(s_1 ^ 0L);
        int vr22 = vr21;
        System.Console.WriteLine(vr22);
    }
}