// Generated by Fuzzlyn on 2018-06-23 00:13:28
// Seed: 8798308757980560169
// Reduced from 15.9 KiB to 0.2 KiB
// Debug: Outputs 65527
// Release: Outputs -9
public class Program
{
    static short s_3 = -10;
    public static void Main()
    {
        var vr3 = (char)(1U | s_3);
        int vr6 = vr3;
        System.Console.WriteLine(vr6);
    }
}