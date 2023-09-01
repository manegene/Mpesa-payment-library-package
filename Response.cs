using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mpesa_pament_lib
{
    public class Response
    {
        //auth response fields
        public string Access_token { get; set; }
        public string Expires_in { get; set; }
    }
}
