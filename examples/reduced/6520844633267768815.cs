// Generated by Fuzzlyn on 2018-07-08 00:08:31
// Seed: 6520844633267768815
// Reduced from 448.0 KiB to 0.2 KiB
// Debug: Outputs 65513
// Release: Outputs -23
public class Program
{
    static sbyte[, ] s_2 = new sbyte[, ]{{-23}};
    public static void Main()
    {
        char vr8 = (char)(1 | s_2[0, 0]);
        System.Console.WriteLine((int)vr8);
    }
}