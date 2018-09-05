using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    interface IPayment
    {
        void SaveCartDetails(List<Cart> UserCartDetails);
    }
}
