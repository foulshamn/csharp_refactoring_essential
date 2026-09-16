namespace Comments;

public class X1
{
    public static int M(int lowerBound, int z)
    {
        int p = 0;

        // Iterate from lower bound (q) to upper bound (z)
        for (int i = lowerBound; i <= z; i++)
        {
            // Add square of each number in the range
            p += i * i;
        }

        // Return accumulated sum
        return p;
    }
}