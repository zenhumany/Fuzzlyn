// Generated by Fuzzlyn on 2018-07-21 12:48:00
// Seed: 11562380070741833612
// Reduced from 20.6 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
struct S2
{
    public short F1;
    public long F2;
    public byte F6;
}

public class Program
{
    static ulong s_4;
    static S2[, ] s_6 = new S2[, ]{{new S2()}};
    public static void Main()
    {
        ulong vr0 = (0 * s_4) & s_6[0, 0].F6;
        s_6[0, 0].F2 += s_6[0, 0].F1;
        System.Console.WriteLine(vr0);
    }
}
