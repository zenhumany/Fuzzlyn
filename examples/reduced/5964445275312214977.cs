// Generated by Fuzzlyn on 2018-06-22 23:32:47
// Seed: 5964445275312214977
// Reduced from 106.4 KiB to 0.2 KiB
// Debug: Outputs 32768
// Release: Outputs 4294934528
public class Program
{
    static short s_9 = -32767;
    public static void Main()
    {
        char vr4 = (char)(1L ^ s_9);
        uint vr5 = vr4;
        System.Console.WriteLine(vr5);
    }
}