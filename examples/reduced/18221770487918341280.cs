// Generated by Fuzzlyn on 2018-07-03 14:07:22
// Seed: 18221770487918341280
// Reduced from 16.3 KiB to 0.3 KiB
// Debug: Outputs 128
// Release: Outputs -128
class C0
{
    public sbyte F0;
    public C0(sbyte f0)
    {
        F0 = f0;
    }
}

public class Program
{
    static C0 s_4 = new C0(-128);
    public static void Main()
    {
        short vr3 = (byte)(s_4.F0 / (long)1);
        System.Console.WriteLine(vr3);
    }
}