namespace Mpesa_pament_lib
{
    public interface BaseInterface
    {
        //authentication method
        Response Auth(string username, string password);

    }
}
