// Generated by Fuzzlyn on 2018-07-18 13:01:46
// Seed: 7439793420885761965
// Reduced from 14.4 KiB to 0.3 KiB
// Debug: Outputs 65442
// Release: Outputs 4294967202
public class Program
{
    static sbyte s_4 = -94;
    public static void Main()
    {
        var vr11 = M16();
        long vr12 = vr11;
        System.Console.WriteLine(vr12);
    }

    static char M16()
    {
        return (char)(0 ^ s_4);
    }
}