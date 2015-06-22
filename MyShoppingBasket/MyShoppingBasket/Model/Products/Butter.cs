namespace MyShoppingBasket.Model.Products
{
    public class Butter : IProduct
    {
        public Money GetPricePerUnit()
        {
            return new Money(.8M);
        }
    }
}
