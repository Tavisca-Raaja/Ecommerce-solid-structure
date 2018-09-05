using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    class CardPayment:IPayment,ICardpayment
    {
        public void SaveCardDetails(List<CardDetails> userCardDetails)//storing user debit/credit card details
        {
            //storing carddetails
        }
        public void SaveCartDetails(List<Cart> UserCartDetails)//storing user purchased items
        {

        }
    }
}
