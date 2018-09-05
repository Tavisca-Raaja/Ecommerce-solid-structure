using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    class CashPayment:IPayment
    {
         public void SaveCartDetails(List<Cart> UserCartDetails)
        {
            //cashpayment so only cartdetails are saved
        }
    }
}
