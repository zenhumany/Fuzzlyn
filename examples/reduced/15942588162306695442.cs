// Generated by Fuzzlyn on 2018-07-03 17:26:43
// Seed: 15942588162306695442
// Reduced from 73.9 KiB to 0.2 KiB
// Debug: Outputs 32768
// Release: Outputs -32768
public class Program
{
    static short s_7 = -32768;
    public static void Main()
    {
        var vr16 = (ushort)(s_7 / 1L);
        int vr17 = vr16;
        System.Console.WriteLine(vr17);
    }
}
