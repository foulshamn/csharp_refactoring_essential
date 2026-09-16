namespace Comments;

public class CommentExercise
{
    public static int AccumulativeSumOfSquaresInRange(int lowerBound, int upperBound)
    {
        var accumulatedSum = 0;

        for (var i = lowerBound; i <= upperBound; i++)
        {
            accumulatedSum += i * i;
        }

        return accumulatedSum;
    }
}