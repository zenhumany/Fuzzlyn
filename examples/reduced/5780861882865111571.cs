// Generated by Fuzzlyn on 2018-07-13 21:12:11
// Seed: 5780861882865111571
// Reduced from 82.1 KiB to 0.4 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static ushort[][, ] s_9 = new ushort[][, ]{new ushort[, ]{{0}}};
    static sbyte s_10 = -128;
    static uint s_11;
    static short[] s_12 = new short[]{0};
    public static void Main()
    {
        var vr26 = s_9[0][0, 0];
        M5();
    }

    static uint M5()
    {
        bool vr0 = (((0 & s_9[0][0, 0]) / s_10) * s_9[0][0, 0]) > s_12[0];
        return s_11;
    }
}
