// Generated by Fuzzlyn on 2018-06-20 13:35:56
// Seed: 17794051369491273163
// Reduced from 39.2 KiB to 0.3 KiB
// Debug: Outputs 65535
// Release: Outputs -1
public class Program
{
    static sbyte[, ] s_1 = new sbyte[, ]{{0}};
    static char s_10;
    public static void Main()
    {
        s_1[0, 0] = -1;
        char vr27 = (char)(s_1[0, 0] | s_10);
        System.Console.WriteLine((int)vr27);
    }
}