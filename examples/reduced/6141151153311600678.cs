// Generated by Fuzzlyn on 2018-06-22 19:39:52
// Seed: 6141151153311600678
// Reduced from 65.8 KiB to 0.5 KiB
// Debug: Outputs 10817397934431922930
// Release: Outputs 0
struct S0
{
    public ulong F6;
    public S0(ulong f6): this()
    {
        F6 = f6;
    }
}

public class Program
{
    static ulong[] s_4 = new ulong[]{0};
    static short s_6 = -32768;
    static S0 s_13 = new S0(10817397934431922930UL);
    public static void Main()
    {
        bool vr4 = 0 < (ushort)(s_6 | 1L);
        if (vr4)
        {
            s_4[0] = s_13.F6;
        }
        else
        {
        }

        System.Console.WriteLine(s_4[0]);
    }
}