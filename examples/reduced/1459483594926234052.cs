// Generated by Fuzzlyn on 2018-07-05 02:06:19
// Seed: 1459483594926234052
// Reduced from 87.3 KiB to 0.2 KiB
// Debug: Outputs 65535
// Release: Outputs -1
public class Program
{
    public static void Main()
    {
        sbyte[, ] vr17 = new sbyte[, ]{{-9}};
        char vr18 = (char)(10U | vr17[0, 0]);
        System.Console.WriteLine((int)vr18);
    }
}