// Generated by Fuzzlyn on 2018-06-18 16:17:10
// Seed: 4799573815638496604
// Reduced from 138.5 KiB to 0.3 KiB
// Debug: Outputs 65423
// Release: Outputs 4294967183
public class Program
{
    static byte s_7;
    public static void Main()
    {
        var vr106 = new sbyte[,, ][, ]{{{new sbyte[, ]{{-113}}}}};
        ulong vr109 = (ushort)(vr106[0, 0, 0][0, 0] ^ s_7);
        System.Console.WriteLine(vr109);
    }
}
