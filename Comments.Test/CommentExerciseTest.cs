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

        int expected = 559;

        int actual = CommentExercise.AccumulativeSumOfSquaresInRange(lowerBound, upperBound);

        Assert.That(actual, Is.EqualTo(expected));
    }
}