// Generated by Fuzzlyn on 2018-07-01 23:53:31
// Seed: 4227443388565619710
// Reduced from 7.2 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    public static void Main()
    {
        var vr7 = new ulong[][][, ]{new ulong[][, ]{new ulong[, ]{{0}}}};
        bool vr9 = (0 & vr7[0][0][0, 0]) != 0;
        if (vr9)
        {
        }
        else
        {
            bool vr10 = 0 <= vr7[0][0][0, 0];
        }
    }
}