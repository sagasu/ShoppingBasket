using System;
using System.Collections.Generic;
using System.Linq;
using MyShoppingBasket.Model;

namespace MyShoppingBasket.Extensions
{
    public static class IEnumerableExtensions
    {
        public static Money Sum<T>(this IEnumerable<T> data, Func<T, Money> selector)
        {
            var money = new Money(0);
            money = data.Select(selector.Invoke).Aggregate(money, (current, selectedMoney) => current + selectedMoney);
            return money;
        }
    }
}
