// Generated by Fuzzlyn on 2018-06-21 15:39:43
// Seed: 15855266021486900163
// Reduced from 17.0 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static long[,, ] s_1 = new long[,, ]{{{0}}};
    public static void Main()
    {
        bool vr2 = (s_1[0, 0, 0] & 0) == 1;
        if (vr2)
        {
        }
        else
        {
            s_1[0, 0, 0] = s_1[0, 0, 0];
        }
    }
}