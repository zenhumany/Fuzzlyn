// Generated by Fuzzlyn on 2018-07-08 17:50:01
// Seed: 14620314336691012100
// Reduced from 255.2 KiB to 0.2 KiB
// Debug: Outputs 65408
// Release: Outputs 4294967168
public class Program
{
    static sbyte[, ] s_29 = new sbyte[, ]{{-128}};
    public static void Main()
    {
        uint vr0 = (ushort)(s_29[0, 0] ^ 0);
        System.Console.WriteLine(vr0);
    }
}