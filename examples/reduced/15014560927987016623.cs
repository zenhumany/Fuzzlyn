// Generated by Fuzzlyn on 2018-07-18 14:31:38
// Seed: 15014560927987016623
// Reduced from 31.9 KiB to 0.2 KiB
// Debug: Outputs 255
// Release: Outputs 4294967295
public class Program
{
    public static void Main()
    {
        sbyte[] vr9 = new sbyte[]{-39};
        vr9[0] = vr9[0];
        uint vr10 = (byte)(255 | vr9[0]);
        System.Console.WriteLine(vr10);
    }
}