using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class User:IUser
    {
       public  bool Login(string userName,string Password)
        {
            return true;
        }
    }
}
