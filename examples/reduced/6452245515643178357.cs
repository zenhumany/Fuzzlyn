// Generated by Fuzzlyn on 2018-06-18 14:49:04
// Seed: 6452245515643178357
// Reduced from 131.3 KiB to 0.3 KiB
// Debug: Outputs 35
// Release: Outputs 1
public class Program
{
    static char s_3 = '#';
    static short[] s_5 = new short[]{32766};
    public static void Main()
    {
        var vr72 = s_3 % (char)M19();
        System.Console.WriteLine(vr72);
    }

    static sbyte M19()
    {
        return (sbyte)s_5[0];
    }
}