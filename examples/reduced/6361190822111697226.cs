// Generated by Fuzzlyn on 2018-07-05 02:46:25
// Seed: 6361190822111697226
// Reduced from 43.5 KiB to 0.2 KiB
// Debug: Outputs 65451
// Release: Outputs 4294967211
public class Program
{
    public static void Main()
    {
        var vr40 = new sbyte[][, ]{new sbyte[, ]{{-85}}};
        var vr42 = (ushort)(vr40[0][0, 0] ^ 0);
        uint vr50 = vr42;
        System.Console.WriteLine(vr50);
    }
}