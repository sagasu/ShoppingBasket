using System.Collections.Generic;
using MyShoppingBasket.Model.Products;

namespace MyShoppingBasket.Model.Discounts
{
    public interface IDiscount
    {
        Money GetDiscount(IList<IProduct> products);
    }
}