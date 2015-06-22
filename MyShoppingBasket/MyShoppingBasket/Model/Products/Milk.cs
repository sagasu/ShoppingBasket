namespace MyShoppingBasket.Model.Products
{
    public class Milk : IProduct
    {
        public Money GetPricePerUnit()
        {
            return new Money(1.15M);
        }
    }
}
