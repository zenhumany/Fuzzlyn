// Generated by Fuzzlyn on 2018-07-14 06:49:47
// Seed: 17923025706463732810
// Reduced from 196.1 KiB to 0.5 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
class C0
{
    public int F0;
    public uint F2;
    public ulong F7;
}

public class Program
{
    static bool s_19;
    static C0[, ] s_25 = new C0[, ]{{new C0()}};
    public static void Main()
    {
        var vr248 = new C0();
        var vr249 = 0 & s_25[0, 0].F2;
        var vr250 = s_25[0, 0].F7;
        M75(vr248, vr249);
    }

    static bool M75(C0 arg0, uint arg4)
    {
        System.Console.WriteLine(arg0.F0);
        return s_19;
    }
}
