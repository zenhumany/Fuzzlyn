// Generated by Fuzzlyn on 2018-07-01 00:51:16
// Seed: 2054992112881700205
// Reduced from 78.0 KiB to 0.4 KiB
// Debug: Outputs 255
// Release: Outputs -1
struct S1
{
    public sbyte F9;
}

class C0
{
    public sbyte F0;
}

public class Program
{
    static C0[] s_9 = new C0[]{new C0()};
    static S1[] s_15 = new S1[]{new S1()};
    public static void Main()
    {
        s_15[0].F9 = s_9[0].F0--;
        var vr47 = (byte)(0U ^ s_9[0].F0);
        short vr48 = vr47;
        System.Console.WriteLine(vr48);
    }
}