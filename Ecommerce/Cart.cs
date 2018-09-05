using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    class Cart:ICart
    {
        List<Item> Purchased {get; set;}
        Decimal TotalAmount {get; set;}
        public void AddItem(int productId,int ProductQuantity)
        {
            //items add into purchased list based on quantity
        }
        public void RemoveItem(int productId, int ProductQuantity)
        {
            //items removed from purchased list based on quantity
        }
        public void ClearCart()
        {
            //to clear whole cart
        }
        public void ShowCart()
        {
            //to display cart
        }
    }
}
