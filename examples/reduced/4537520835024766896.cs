// Generated by Fuzzlyn on 2018-08-02 01:36:36
// Seed: 4537520835024766896
// Reduced from 1.0 KiB to 0.2 KiB
// Debug: Outputs -65
// Release: Outputs -55
public class Program
{
    public static void Main()
    {
        byte[] vr0 = new byte[]{254};
        sbyte vr1 = (sbyte)(33983 % (ushort)(0 - vr0[0]));
        System.Console.WriteLine(vr1);
    }
}