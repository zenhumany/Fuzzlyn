// Generated by Fuzzlyn on 2018-07-16 02:55:15
// Seed: 6367621324611533923
// Reduced from 45.4 KiB to 0.3 KiB
// Debug: Outputs 65526
// Release: Outputs -10
public class Program
{
    static sbyte s_6 = -10;
    public static void Main()
    {
        var vr6 = M17();
        int vr7 = vr6;
        System.Console.WriteLine(vr7);
    }

    static char M17()
    {
        ushort vr3 = (ushort)(s_6 ^ 0);
        return (char)vr3;
    }
}
