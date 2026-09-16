namespace LegacyCode;

public interface IOrderRequestHandler
{
    Order? GetOrder(int orderId);
}