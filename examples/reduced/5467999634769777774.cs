// Generated by Fuzzlyn on 2018-07-04 07:52:58
// Seed: 5467999634769777774
// Reduced from 280.1 KiB to 0.4 KiB
// Debug: Runs successfully
// Release: Throws 'System.IndexOutOfRangeException'
struct S0
{
    public int F0;
    public uint F3;
}

public class Program
{
    static long s_1;
    public static void Main()
    {
        S0[][, ] vr11 = M5();
        s_1 = (0 & vr11[0][0, 0].F3);
        vr11[0][0, 0].F0 = vr11[0][0, 0].F0;
    }

    static S0[][, ] M5()
    {
        return new S0[][, ]{new S0[, ]{{new S0()}}};
    }
}