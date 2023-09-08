using Mpesa_pament_lib.Objs_folder;

namespace Mpesa_pament_lib
{
    public interface BaseInterface
    {
        //authentication method
       public Task<AuthResponse> Auth(string username, string password, bool dev);

        /*
         * register confirmation and validation urls
         * the validation URL must contain the default action if enabled. Otherwise, should be disbaled
         * contact Safaricom for activation of the validation URL
         */
        public Task<C2B_Reg_Url_Response> ConfirmationValidationUrl(C2B_Reg_Url_req req);
    }
}
