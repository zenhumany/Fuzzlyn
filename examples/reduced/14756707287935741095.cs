// Generated by Fuzzlyn on 2018-07-08 07:53:44
// Seed: 14756707287935741095
// Reduced from 80.0 KiB to 0.3 KiB
// Debug: Outputs 255
// Release: Outputs -1
public class Program
{
    static sbyte s_1;
    public static void Main()
    {
        var vr50 = s_1--;
        long vr60 = default(long);
        byte vr61 = (byte)(s_1 ^ vr60);
        short vr64 = vr61;
        System.Console.WriteLine(vr64);
    }
}