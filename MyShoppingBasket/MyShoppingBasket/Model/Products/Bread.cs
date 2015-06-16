namespace MyShoppingBasket.Model.Products
{
    public class Bread : IProduct
    {
        public Money GetPrice()
        {
            return new Money(1M);
        }
    }
}
