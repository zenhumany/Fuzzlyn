// Generated by Fuzzlyn on 2018-07-20 11:14:09
// Seed: 17215960825771862751
// Reduced from 128.7 KiB to 0.2 KiB
// Debug: Outputs 65535
// Release: Outputs -1
public class Program
{
    static ushort s_2 = 1;
    public static void Main()
    {
        char vr10 = M24();
        System.Console.WriteLine((int)vr10);
    }

    static char M24()
    {
        return (char)(s_2 * 4294967295U);
    }
}