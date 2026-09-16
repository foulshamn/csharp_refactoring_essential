namespace Comments;

public class X1
{
    public static int M(int lowerBound, int upperBound)
    {
        var accumulatedSum = 0;

        for (var i = lowerBound; i <= upperBound; i++)
        {
            // Add square of each number in the range
            accumulatedSum += i * i;
        }

        // Return accumulated sum
        return accumulatedSum;
    }
}