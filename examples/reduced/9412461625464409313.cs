// Generated by Fuzzlyn on 2018-07-08 06:21:47
// Seed: 9412461625464409313
// Reduced from 2.1 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static char[][, ] s_1 = new char[][, ]{new char[, ]{{'g'}}};
    public static void Main()
    {
        bool vr3 = (0 & (s_1[0][0, 0] - (s_1[0][0, 0] % 6569265186805237165L))) >= 0;
        if (vr3)
        {
            s_1 = new char[][, ]{new char[, ]{{'4'}}};
        }
        else
        {
        }
    }
}