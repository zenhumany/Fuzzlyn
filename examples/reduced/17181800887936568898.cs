// Generated by Fuzzlyn on 2018-07-07 20:43:17
// Seed: 17181800887936568898
// Reduced from 77.8 KiB to 0.3 KiB
// Debug: Outputs 65485
// Release: Outputs 4294967245
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
    static S0 s_3 = new S0(-51);
    public static void Main()
    {
        short vr9 = default(short);
        ulong vr10 = (ushort)(vr9 ^ s_3.F0);
        System.Console.WriteLine(vr10);
    }
}