// Generated by Fuzzlyn on 2018-06-24 05:53:46
// Seed: 1160440316705006644
// Reduced from 40.6 KiB to 0.3 KiB
// Debug: Outputs 33215
// Release: Outputs -32321
class C0
{
    public int F1;
    public short F4;
    public C0(short f4)
    {
        F4 = f4;
    }
}

public class Program
{
    static C0 s_3 = new C0(-32322);
    public static void Main()
    {
        s_3.F1 = (ushort)(1L | s_3.F4);
        System.Console.WriteLine(s_3.F1);
    }
}