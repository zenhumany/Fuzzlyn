// Generated by Fuzzlyn on 2018-07-11 08:19:41
// Seed: 3374709333861778218
// Reduced from 51.5 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
struct S0
{
    public S0(long f0): this()
    {
    }
}

public class Program
{
    static sbyte[,, ] s_2 = new sbyte[,, ]{{{0}}};
    public static void Main()
    {
        var vr16 = new S0(((0 & s_2[0, 0, 0]) / (s_2[0, 0, 0] | 1)));
    }
}