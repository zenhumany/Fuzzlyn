// Generated by Fuzzlyn on 2018-07-22 12:18:15
// Seed: 3654826645213253824
// Reduced from 197.6 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static uint s_5;
    static uint[,, ] s_29 = new uint[,, ]{{{0}}};
    static bool s_66;
    public static void Main()
    {
        s_66 = 0 != (0 & s_29[0, 0, 0]);
        s_29[0, 0, 0] = s_5;
    }
}