// Generated by Fuzzlyn on 2018-07-06 07:02:57
// Seed: 14017084872269662313
// Reduced from 84.8 KiB to 0.3 KiB
// Debug: Outputs 0
// Release: Outputs 68
public class Program
{
    static char s_2 = 'D';
    static int s_8;
    public static void Main()
    {
        var vr15 = new short[]{-18647};
        bool vr19 = (char)(1L ^ vr15[0]) >= '6';
        if (vr19)
        {
            s_2 = (char)s_8;
        }

        System.Console.WriteLine((int)s_2);
    }
}