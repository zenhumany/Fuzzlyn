// Generated by Fuzzlyn on 2018-07-23 22:31:41
// Seed: 2703486126607878760
// Reduced from 6.4 KiB to 0.5 KiB
// Debug: Outputs 18446744073709551615
// Release: Outputs 0
struct S0
{
    public uint F2;
    public ushort F3;
    public int F4;
    public uint F6;
}

struct S1
{
    public ulong F2;
    public S0 F7;
    public S1(ulong f2, S0 f7): this()
    {
        F2 = f2;
        F7 = f7;
    }
}

struct S2
{
    public S1 F0;
}

public class Program
{
    public static void Main()
    {
        S2 vr14;
        vr14.F0 = new S1(18446744073709551615UL, new S0());
        ulong vr15 = vr14.F0.F2;
        System.Console.WriteLine(vr15);
    }
}
