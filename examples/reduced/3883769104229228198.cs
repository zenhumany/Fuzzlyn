// Generated by Fuzzlyn on 2018-06-29 05:02:41
// Seed: 3883769104229228198
// Reduced from 1.0 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    public static void Main()
    {
        byte[][, ] vr0 = new byte[][, ]{new byte[, ]{{0}}};
        int vr1 = 0 & vr0[0][0, 0];
        vr0[0][0, 0] = vr0[0][0, 0];
        System.Console.WriteLine(vr1);
    }
}