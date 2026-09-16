namespace Comments.Test;

using NUnit.Framework;

[TestFixture]
public class CommentExerciseTest
{
    [Test]
    public void AccumulativeSumOfSquaresInRangeTest()
    {
        int lowerBound = 7;
        int upperBound = 12;

        // Expected: sum of squares from 7 to 12
        int expected = 0;
        for (int i = lowerBound; i <= upperBound; i++)
        {
            expected += i * i;
        }

        int actual = CommentExercise.AccumulativeSumOfSquaresInRange(lowerBound, upperBound);

        Assert.That(actual, Is.EqualTo(expected));
    }
}