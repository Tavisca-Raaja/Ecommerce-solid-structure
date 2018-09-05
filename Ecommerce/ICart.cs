using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    interface ICart
    {
        void AddItem(int productId, int ProductQuantity);
        void RemoveItem(int productId, int ProductQuantity);
        void ShowCart();
        void ClearCart();
    }
}
