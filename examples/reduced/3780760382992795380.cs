// Generated by Fuzzlyn on 2018-06-22 23:23:29
// Seed: 3780760382992795380
// Reduced from 42.7 KiB to 0.4 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static short[, ] s_2 = new short[, ]{{0}};
    static char[] s_3;
    public static void Main()
    {
        var vr20 = 0 & s_2[0, 0];
        var vr21 = (ulong)s_2[0, 0];
        M11(vr21, vr20);
    }

    static char[] M11(ulong arg0, int arg2)
    {
        System.Console.WriteLine(arg0);
        return s_3;
    }
}