// Generated by Fuzzlyn on 2018-07-10 05:17:43
// Seed: 14275149473007448533
// Reduced from 7.8 KiB to 0.5 KiB
// Debug: Outputs 1
// Release: Outputs 32769
struct S0
{
    public short F0;
    public short F1;
    public ulong F2;
}

public class Program
{
    static ushort s_1;
    public static void Main()
    {
        var vr2 = new S0();
        s_1 = (ushort)M1(vr2);
        System.Console.WriteLine(s_1);
    }

    static sbyte M1(S0 arg0)
    {
        arg0.F1 = arg0.F0;
        arg0.F1 = -32768;
        arg0.F2 = arg0.F2;
        arg0.F0 = 0;
        return (sbyte)(1 | arg0.F1);
    }
}