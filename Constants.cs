using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mpesa_pament_lib
{
    public class Constants
    {
        //APi addresses - sandbox and prod base addresses.
        public string Dev { get; } = "https://sandbox.safaricom.co.ke/";
        public string Prod { get; } = "https://api.safaricom.co.ke/";
    }
}
