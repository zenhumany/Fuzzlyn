// Generated by Fuzzlyn on 2018-06-26 09:35:37
// Seed: 4528327383934190349
// Reduced from 30.5 KiB to 0.8 KiB
// Debug: Runs successfully
// Release: Throws 'System.IndexOutOfRangeException'
class C0
{
    public ulong F2;
    public bool F3;
    public C0(long f1, ulong f2, bool f3, int f4, long f5, long f6, int f7)
    {
    }
}

class C1
{
    public bool F4;
    public C0 F8;
    public C1(C0 f8)
    {
        F8 = f8;
    }
}

public class Program
{
    public static void Main()
    {
        C1[][, ] vr10 = new C1[][, ]{new C1[, ]{{new C1(new C0(0, 0, true, 0, 0, 0, 0))}}};
        bool vr11 = vr10[0][0, 0].F8.F3;
        if (vr11)
        {
        }
        else
        {
            vr10 = new C1[][, ]{new C1[, ]{{new C1(new C0(0, 0, true, 0, 0, 0, 0))}}};
        }

        var vr12 = (char)(vr10[0][0, 0].F8.F2 & 0);
        M1(vr12);
        System.Console.WriteLine(vr10[0][0, 0].F4);
    }

    static C0 M1(char arg0)
    {
        return new C0(0, 0, false, 0, 0, 0, 0);
    }
}