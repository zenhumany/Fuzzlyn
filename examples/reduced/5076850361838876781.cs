// Generated by Fuzzlyn on 2018-06-30 20:50:05
// Seed: 5076850361838876781
// Reduced from 200.3 KiB to 0.5 KiB
// Debug: Outputs 22635
// Release: Outputs 66
class C0
{
    public sbyte F3;
    public short F4;
    public C0(sbyte f3)
    {
        F3 = f3;
    }
}

public class Program
{
    static int[] s_22 = new int[]{1713778338};
    static C0 s_44 = new C0(0);
    static uint[, ] s_51 = new uint[, ]{{0}};
    static C0 s_72 = new C0(-103);
    public static void Main()
    {
        s_44.F4 = (short)(s_22[0] % (ushort)(s_72.F3 | (int)s_51[0, 0]));
        System.Console.WriteLine(s_44.F4);
    }
}