// Generated by Fuzzlyn on 2018-07-29 23:31:00
// Seed: 11014595563209230347
// Reduced from 7.3 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static byte[, ] s_1 = new byte[, ]{{0}};
    public static void Main()
    {
        var vr8 = (0 & s_1[0, 0]) % (M1(s_1[0, 0]) | 1);
    }

    static short M1(byte arg2)
    {
        return 0;
    }
}