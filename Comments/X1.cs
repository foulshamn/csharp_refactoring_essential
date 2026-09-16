namespace Comments;

public class X1
{
    public static int M(int lowerBound, int upperBound)
    {
        int accumulatedSum = 0;

        for (int i = lowerBound; i <= upperBound; i++)
        {
            // Add square of each number in the range
            accumulatedSum += i * i;
        }

        // Return accumulated sum
        return accumulatedSum;
    }
}