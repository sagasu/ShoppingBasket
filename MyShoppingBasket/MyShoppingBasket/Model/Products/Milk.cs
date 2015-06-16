namespace MyShoppingBasket.Model.Products
{
    public class Milk : IProduct
    {
        public Money GetPrice()
        {
            return new Money(1.15M);
        }
    }
}
