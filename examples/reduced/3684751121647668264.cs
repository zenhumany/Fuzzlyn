// Generated by Fuzzlyn on 2018-07-14 12:44:02
// Seed: 3684751121647668264
// Reduced from 42.6 KiB to 0.4 KiB
// Debug: Outputs 65497
// Release: Outputs -39
struct S0
{
    public char F1;
    public S0(char f1): this()
    {
        F1 = f1;
    }
}

class C0
{
    public sbyte F2;
    public C0(sbyte f2)
    {
        F2 = f2;
    }
}

public class Program
{
    static C0 s_5 = new C0(-39);
    public static void Main()
    {
        S0 vr23 = new S0((char)(0 ^ s_5.F2));
        System.Console.WriteLine((int)vr23.F1);
    }
}