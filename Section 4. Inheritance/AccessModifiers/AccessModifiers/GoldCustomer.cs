namespace AccessModifiers;

public class GoldCustomer : Customer
{
    public void OfferVoucher()
    {
        var rating = this.CalculateRating(excludeOrders: true);
    }
}