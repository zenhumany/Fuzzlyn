// Generated by Fuzzlyn on 2018-06-20 10:22:36
// Seed: 3646929944714968768
// Reduced from 207.1 KiB to 0.3 KiB
// Debug: Outputs 0
// Release: Outputs 1439
struct S0
{
    public short F0;
}

struct S1
{
    public S0 F3;
    public ushort F4;
}

public class Program
{
    static S1 s_66;
    public static void Main()
    {
        s_66.F3 = M41();
        System.Console.WriteLine(s_66.F4);
    }

    static S0 M41()
    {
        return new S0();
    }
}
