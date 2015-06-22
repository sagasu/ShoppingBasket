namespace MyShoppingBasket.Model.Products
{
    public class Butter : IProduct
    {
        public static Money Price = new Money(.8M);

        public Money GetPricePerUnit()
        {
            return Price;
        }
    }
}
