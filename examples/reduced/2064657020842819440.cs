// Generated by Fuzzlyn v1.1 on 2018-08-02 16:08:16
// Seed: 2064657020842819440
// Reduced from 2.4 KiB to 0.2 KiB
// Debug: Outputs 65517
// Release: Outputs -19
public class Program
{
    static sbyte s_1 = -83;
    public static void Main()
    {
        int vr0 = (ushort)(76 | M1());
        System.Console.WriteLine(vr0);
    }

    static sbyte M1()
    {
        return s_1;
    }
}
