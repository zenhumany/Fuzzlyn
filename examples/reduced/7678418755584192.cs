// Generated by Fuzzlyn on 2018-07-03 12:59:46
// Seed: 7678418755584192
// Reduced from 31.8 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static int[][, ] s_6 = new int[][, ]{new int[, ]{{0}}};
    public static void Main()
    {
        long vr0 = s_6[0][0, 0] & 0;
        s_6[0] = new int[, ]{{0}};
        System.Console.WriteLine(vr0);
    }
}