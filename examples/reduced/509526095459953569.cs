// Generated by Fuzzlyn on 2018-07-10 04:17:41
// Seed: 509526095459953569
// Reduced from 8.5 KiB to 0.3 KiB
// Debug: Outputs -1
// Release: Outputs 65535
public class Program
{
    static int s_1;
    static ushort[][][] s_2 = new ushort[][][]{new ushort[][]{new ushort[]{0}}};
    public static void Main()
    {
        s_2[0][0][0] = 65535;
        short vr8 = (short)s_2[0][0][0]++;
        s_1 = vr8;
        System.Console.WriteLine(s_1);
    }
}