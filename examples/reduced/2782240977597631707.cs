// Generated by Fuzzlyn on 2018-06-22 13:26:54
// Seed: 2782240977597631707
// Reduced from 69.5 KiB to 0.3 KiB
// Debug: Outputs 65535
// Release: Outputs -1
public class Program
{
    static short s_1;
    public static void Main()
    {
        long vr28 = default(long);
        var vr29 = vr28--;
        s_1 = (short)vr28;
        var vr31 = (char)(0L | s_1);
        int vr32 = vr31;
        System.Console.WriteLine(vr32);
    }
}