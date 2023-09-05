namespace Mpesa_pament_lib
{
    public interface BaseInterface
    {
        //authentication method
       public Task<AuthResponse> Auth(string username, string password, bool dev);

    }
}
