// Generated by Fuzzlyn on 2018-07-06 08:06:47
// Seed: 1221214722841069827
// Reduced from 54.7 KiB to 0.4 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static sbyte[][][,, ][, ] s_1 = new sbyte[][][,, ][, ]{new sbyte[][,, ][, ]{new sbyte[,, ][, ]{{{new sbyte[, ]{{0}}}}}}};
    static long[][, ] s_8;
    public static void Main()
    {
        bool vr6 = ((s_1[0][0][0, 0, 0][0, 0] & 0) - s_1[0][0][0, 0, 0][0, 0]) == 0;
        if (vr6)
        {
            s_8 = s_8;
        }
        else
        {
        }
    }
}