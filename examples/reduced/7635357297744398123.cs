// Generated by Fuzzlyn on 2018-06-25 14:43:45
// Seed: 7635357297744398123
// Reduced from 215.2 KiB to 0.3 KiB
// Debug: Prints 0 line(s)
// Release: Prints 1 line(s)
public class Program
{
    static short s_11 = -20770;
    public static void Main()
    {
        short vr12 = default(short);
        ushort vr13 = (ushort)(s_11 / (long)1);
        bool vr14 = 0 > vr13;
        if (vr14)
        {
            System.Console.WriteLine(vr12);
        }
        else
        {
        }
    }
}
