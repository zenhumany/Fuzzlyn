// Generated by Fuzzlyn on 2018-06-19 14:35:24
// Seed: 4266957452102511812
// Reduced from 127.4 KiB to 0.2 KiB
// Debug: Outputs 65526
// Release: Outputs -10
public class Program
{
    static sbyte s_64 = -10;
    public static void Main()
    {
        ushort vr4 = default(ushort);
        char vr5 = (char)(s_64 ^ vr4);
        System.Console.WriteLine((int)vr5);
    }
}