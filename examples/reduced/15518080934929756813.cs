// Generated by Fuzzlyn on 2018-06-24 00:13:14
// Seed: 15518080934929756813
// Reduced from 103.6 KiB to 0.3 KiB
// Debug: Outputs 255
// Release: Outputs -1
struct S0
{
    public sbyte F1;
    public S0(sbyte f1): this()
    {
        F1 = f1;
    }
}

public class Program
{
    static S0 s_12 = new S0(-1);
    public static void Main()
    {
        var vr13 = (byte)(0L ^ s_12.F1);
        System.Console.WriteLine((int)vr13);
    }
}