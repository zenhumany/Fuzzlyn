// Generated by Fuzzlyn on 2018-07-18 10:49:38
// Seed: 2162394781690956755
// Reduced from 11.3 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static bool s_3 = true;
    static uint[, ] s_4 = new uint[, ]{{0}};
    public static void Main()
    {
        sbyte vr0;
        int vr1 = 0;
        if (s_3)
        {
            vr0 = (sbyte)(s_4[0, 0] * vr1);
            s_4[0, 0] = s_4[0, 0];
            System.Console.WriteLine(vr0);
        }
    }
}