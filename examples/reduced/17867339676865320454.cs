// Generated by Fuzzlyn on 2018-07-04 01:19:14
// Seed: 17867339676865320454
// Reduced from 25.3 KiB to 0.2 KiB
// Debug: Outputs 65535
// Release: Outputs 4294967295
public class Program
{
    static short[, ] s_7 = new short[, ]{{-2}};
    public static void Main()
    {
        var vr6 = (char)(1U ^ s_7[0, 0]);
        uint vr9 = vr6;
        System.Console.WriteLine(vr9);
    }
}