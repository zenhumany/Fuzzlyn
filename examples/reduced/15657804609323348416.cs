// Generated by Fuzzlyn on 2018-06-22 11:55:53
// Seed: 15657804609323348416
// Reduced from 167.6 KiB to 0.4 KiB
// Debug: Outputs 34371
// Release: Outputs 4294936131
struct S0
{
    public uint F1;
    public short F3;
    public S0(short f3): this()
    {
        F3 = f3;
    }
}

public class Program
{
    static S0 s_8 = new S0(-31165);
    static S0 s_43;
    public static void Main()
    {
        char vr24 = (char)(s_8.F3 ^ 0U);
        s_43.F1 = vr24;
        System.Console.WriteLine(s_43.F1);
    }
}