// Generated by Fuzzlyn on 2018-06-20 23:15:56
// Seed: 17764973836456123618
// Reduced from 106.6 KiB to 0.4 KiB
// Debug: Outputs 65426
// Release: Outputs -110
struct S0
{
    public ulong F1;
    public byte F4;
    public ushort F5;
    public sbyte F6;
    public byte F8;
    public S0(sbyte f6): this()
    {
        F6 = f6;
    }
}

public class Program
{
    static S0 s_3 = new S0(-110);
    public static void Main()
    {
        char vr22 = M9(s_3);
        System.Console.WriteLine((int)vr22);
    }

    static char M9(S0 arg0)
    {
        return (char)(0 ^ arg0.F6);
    }
}