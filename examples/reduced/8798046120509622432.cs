// Generated by Fuzzlyn on 2018-07-10 04:50:10
// Seed: 8798046120509622432
// Reduced from 100.1 KiB to 0.2 KiB
// Debug: Outputs 32769
// Release: Outputs -32767
public class Program
{
    public static void Main()
    {
        short[] vr3 = new short[]{-32767};
        char vr4 = (char)(vr3[0] ^ (long)0);
        System.Console.WriteLine((int)vr4);
    }
}