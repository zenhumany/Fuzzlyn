// Generated by Fuzzlyn on 2018-06-26 21:28:14
// Seed: 14027558260203941621
// Reduced from 155.5 KiB to 0.2 KiB
// Debug: Outputs 244
// Release: Outputs 65524
public class Program
{
    static sbyte s_1;
    public static void Main()
    {
        s_1 = -10;
        byte vr37 = (byte)(2U ^ s_1);
        ushort vr33 = vr37;
        System.Console.WriteLine(vr33);
    }
}