using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mpesa_pament_lib.Objs_folder
{
    public class C2B_Validation_Response
    {
        public string ResultCode { get; set; }
        public string ResultDesc { get; set; }
        public string ThirdPartyTransID { get; set; }
    }
}
