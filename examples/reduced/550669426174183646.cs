// Generated by Fuzzlyn on 2018-06-20 15:40:50
// Seed: 550669426174183646
// Reduced from 158.4 KiB to 0.4 KiB
// Debug: Outputs 65408
// Release: Outputs 4294967168
class C0
{
    public char F4;
}

public class Program
{
    static sbyte[] s_5 = new sbyte[]{-128};
    static C0 s_8 = new C0();
    public static void Main()
    {
        char vr29 = M12();
        ulong vr31 = vr29;
        System.Console.WriteLine(vr31);
    }

    static char M12()
    {
        return (char)(s_8.F4 ^ s_5[0]);
    }
}