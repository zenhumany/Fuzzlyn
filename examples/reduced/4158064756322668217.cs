// Generated by Fuzzlyn on 2018-07-23 12:13:22
// Seed: 4158064756322668217
// Reduced from 6.0 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static long[, ] s_2 = new long[, ]{{-2249636468229703539L}};
    public static void Main()
    {
        byte vr4 = (byte)((s_2[0, 0] & 0) % s_2[0, 0]);
    }
}
