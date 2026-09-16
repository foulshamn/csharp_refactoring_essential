namespace Comments.Test;

using NUnit.Framework;

[TestFixture]
public class CommentExerciseTest
{
    [Test]
    public void AccumulativeSumOfSquaresInRangeTest()
    {
        const int lowerBound = 7;
        const int upperBound = 12;

        const int expected = 559;

        var actual = CommentExercise.AccumulativeSumOfSquaresInRange(lowerBound, upperBound);

        Assert.That(actual, Is.EqualTo(expected));
    }
}