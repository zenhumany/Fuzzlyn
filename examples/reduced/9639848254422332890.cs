// Generated by Fuzzlyn on 2018-07-12 23:53:58
// Seed: 9639848254422332890
// Reduced from 30.5 KiB to 0.4 KiB
// Debug: Outputs 65423
// Release: Outputs 4294967183
public class Program
{
    static sbyte s_3;
    static uint s_9;
    public static void Main()
    {
        uint vr17 = (char)((0 & M1()) | s_3);
        System.Console.WriteLine(vr17);
    }

    static char M1()
    {
        M5(s_9);
        s_3 = -113;
        return '#';
    }

    static uint M5(uint arg0)
    {
        return 0;
    }
}