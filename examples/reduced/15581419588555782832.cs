// Generated by Fuzzlyn on 2018-07-05 18:21:21
// Seed: 15581419588555782832
// Reduced from 35.4 KiB to 0.3 KiB
// Debug: Outputs -1
// Release: Outputs 65535
struct S0
{
    public sbyte F0;
    public S0(sbyte f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    public static void Main()
    {
        S0 vr12 = new S0(-98);
        char vr13 = (char)(vr12.F0 | 32767);
        System.Console.WriteLine((int)vr13);
    }
}