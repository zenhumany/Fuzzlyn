// Generated by Fuzzlyn on 2018-06-25 09:29:51
// Seed: 1654032672039201066
// Reduced from 179.4 KiB to 0.2 KiB
// Debug: Outputs 129
// Release: Outputs 1703372737
public class Program
{
    static sbyte s_12 = 127;
    public static void Main()
    {
        var vr60 = s_12++;
        var vr61 = (byte)(s_12 ^ 1U) % 2591594432U;
        System.Console.WriteLine(vr61);
    }
}
