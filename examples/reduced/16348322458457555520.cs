// Generated by Fuzzlyn on 2018-06-30 14:16:44
// Seed: 16348322458457555520
// Reduced from 6.1 KiB to 0.2 KiB
// Debug: Outputs 65535
// Release: Outputs -1
public class Program
{
    public static void Main()
    {
        sbyte[, ] vr6 = new sbyte[, ]{{-1}};
        char vr7 = (char)(vr6[0, 0] ^ 0);
        System.Console.WriteLine((int)vr7);
    }
}
