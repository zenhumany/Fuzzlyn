// Generated by Fuzzlyn on 2018-07-31 02:51:34
// Seed: 13521422071655321666
// Reduced from 180.4 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static short s_51;
    static sbyte[,, ] s_65 = new sbyte[,, ]{{{0}}};
    public static void Main()
    {
        s_51 = (short)(0 & s_65[0, 0, 0]);
        bool vr42 = 0 >= s_65[0, 0, 0];
    }
}