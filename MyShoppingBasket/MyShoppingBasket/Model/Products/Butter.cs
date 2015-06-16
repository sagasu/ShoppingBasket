namespace MyShoppingBasket.Model.Products
{
    public class Butter : IProduct
    {
        public Money GetPrice()
        {
            return new Money(.8M);
        }
    }
}
