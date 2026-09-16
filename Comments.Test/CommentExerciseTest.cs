namespace Comments.Test;

using NUnit.Framework;

[TestFixture]
public class CommentExerciseTest
{
    [Test]
    public void AccumulativeSumOfSquaresInRangeTest()
    {
        int lowerBound = 7;
        int b = 12;

        // Expected: sum of squares from 7 to 12
        int expected = 0;
        for (int i = lowerBound; i <= b; i++)
        {
            expected += i * i;
        }

        int actual = CommentExercise.AccumulativeSumOfSquaresInRange(lowerBound, b);

        Assert.That(actual, Is.EqualTo(expected));
    }
}