namespace FeatureEnvy.Test;

using NUnit.Framework;

[TestFixture]
public class PriceCalculatorTests
{
    private readonly PriceCalculator calculator = new PriceCalculator();

    [Test]
    public void ShouldApplyDiscountWhenProductIsOnSale()
    {
        Product product = new Product(100.0, true);

        double result = product.CalculateFinalPrice();

        Assert.AreEqual(80.0, result);
    }

    [Test]
    public void ShouldNotApplyDiscountWhenProductIsNotOnSale()
    {
        Product product = new Product(100.0, false);

        double result = product.CalculateFinalPrice();

        Assert.AreEqual(100.0, result);
    }

    [Test]
    public void ShouldReturnZeroWhenPriceIsZeroEvenIfOnSale()
    {
        Product product = new Product(0.0, true);

        double result = product.CalculateFinalPrice();

        Assert.AreEqual(0.0, result);
    }
}