// Generated by Fuzzlyn on 2018-07-25 10:13:03
// Seed: 7900777947737462144
// Reduced from 15.2 KiB to 0.3 KiB
// Debug: Outputs 679220601
// Release: Outputs 5497
public class Program
{
    public static void Main()
    {
        var vr10 = new int[]{0};
        vr10[0] = 679220601;
        var vr15 = (char)vr10[0];
        var vr16 = vr10[0];
        char vr17 = vr15;
        System.Console.WriteLine(vr16);
    }
}
