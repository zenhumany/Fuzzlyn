// Generated by Fuzzlyn on 2018-07-23 05:45:17
// Seed: 7344020461169295956
// Reduced from 58.7 KiB to 0.2 KiB
// Debug: Outputs 65409
// Release: Outputs -127
public class Program
{
    static sbyte[, ] s_3 = new sbyte[, ]{{-127}};
    public static void Main()
    {
        char vr2 = (char)(s_3[0, 0] ^ 0);
        System.Console.WriteLine((int)vr2);
    }
}
