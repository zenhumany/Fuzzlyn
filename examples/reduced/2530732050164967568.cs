// Generated by Fuzzlyn on 2018-07-11 22:22:01
// Seed: 2530732050164967568
// Reduced from 35.1 KiB to 0.3 KiB
// Debug: Outputs 65464
// Release: Outputs 4294967224
public class Program
{
    static ulong[] s_4 = new ulong[]{0};
    static sbyte s_8 = -72;
    public static void Main()
    {
        char vr0 = M16();
        s_4[0] = vr0;
        System.Console.WriteLine(s_4[0]);
    }

    static char M16()
    {
        return (char)(0 ^ s_8);
    }
}