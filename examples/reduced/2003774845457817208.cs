// Generated by Fuzzlyn on 2018-06-19 22:15:15
// Seed: 2003774845457817208
// Reduced from 120.2 KiB to 0.2 KiB
// Debug: Outputs 203
// Release: Outputs -53
public class Program
{
    public static void Main()
    {
        var vr10 = new sbyte[][][]{new sbyte[][]{new sbyte[]{-53}}};
        long vr19 = (byte)(vr10[0][0][0] ^ (long)0);
        System.Console.WriteLine((int)vr19);
    }
}
