// Generated by Fuzzlyn on 2018-07-04 15:56:53
// Seed: 17016596311463503417
// Reduced from 218.5 KiB to 0.4 KiB
// Debug: Prints 0 line(s)
// Release: Prints 1 line(s)
public class Program
{
    static int s_16;
    public static void Main()
    {
        var vr33 = new sbyte[][]{new sbyte[]{-117}};
        var vr34 = new short[,, ]{{{0}}};
        ulong vr40 = default(ulong);
        bool vr41 = (-9201 / (char)(vr34[0, 0, 0] | vr33[0][0])) != s_16;
        if (vr41)
        {
            System.Console.WriteLine(vr40);
        }
        else
        {
        }
    }
}
