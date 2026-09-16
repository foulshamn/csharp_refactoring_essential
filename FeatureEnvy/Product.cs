namespace FeatureEnvy;

public class Product
{
    private readonly double price;
    private readonly bool onSale;

    public Product(double price, bool onSale)
    {
        this.price = price;
        this.onSale = onSale;
    }

    public bool IsOnSale()
    {
        return onSale;
    }

    public double CalculateFinalPrice()
    {
        double finalPrice = this.price;

        if (this.IsOnSale())
        {
            finalPrice = finalPrice * 0.8;
        }

        return finalPrice;
    }
}