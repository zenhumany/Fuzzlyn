// Generated by Fuzzlyn on 2018-07-11 17:46:49
// Seed: 17678410009657084738
// Reduced from 109.4 KiB to 0.3 KiB
// Debug: Outputs 44852
// Release: Outputs 4294946612
class C0
{
    public ulong F2;
    public short F4;
    public C0(short f4)
    {
        F4 = f4;
    }
}

public class Program
{
    public static void Main()
    {
        var vr27 = new C0(-20683);
        vr27.F2 = (char)(vr27.F4 ^ 1U);
        System.Console.WriteLine(vr27.F2);
    }
}
