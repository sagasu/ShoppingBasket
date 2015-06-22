namespace MyShoppingBasket.Model.Products
{
    public class Milk : IProduct
    {
        public static Money Price = new Money(1.15M);

        public Money GetPricePerUnit()
        {
            return Price;
        }
    }
}
