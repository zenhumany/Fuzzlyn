// Generated by Fuzzlyn on 2018-07-21 07:39:18
// Seed: 13721913545929324746
// Reduced from 7.3 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
struct S0
{
    public bool F2;
}

struct S1
{
    public S0 F0;
    public char F2;
}

public class Program
{
    static S1[, ] s_2 = new S1[, ]{{new S1()}};
    public static void Main()
    {
        ushort vr1 = (ushort)(s_2[0, 0].F2 & 0);
        bool vr2 = s_2[0, 0].F0.F2;
        System.Console.WriteLine(vr1);
    }
}