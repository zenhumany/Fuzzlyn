// Generated by Fuzzlyn on 2018-07-02 03:57:30
// Seed: 400861566913555549
// Reduced from 51.7 KiB to 0.2 KiB
// Debug: Outputs 47385
// Release: Outputs -18151
public class Program
{
    static short[, ] s_3 = new short[, ]{{-18152}};
    public static void Main()
    {
        char vr17 = (char)(s_3[0, 0] ^ 1L);
        System.Console.WriteLine((int)vr17);
    }
}