// Generated by Fuzzlyn on 2018-06-26 09:57:35
// Seed: 5487539410808707712
// Reduced from 4.7 KiB to 0.4 KiB
// Debug: Prints 1 line(s)
// Release: Prints 0 line(s)
public class Program
{
    static sbyte[][] s_1 = new sbyte[][]{new sbyte[]{-10}};
    public static void Main()
    {
        long[][] vr1;
        char vr2 = '&';
        bool vr3 = 0 < (ushort)(s_1[0][0] | vr2);
        if (vr3)
        {
            vr1 = new long[][]{new long[]{0}};
            System.Console.WriteLine(vr1[0][0]);
        }
        else
        {
        }
    }
}