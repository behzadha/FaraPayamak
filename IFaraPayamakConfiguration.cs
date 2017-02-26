namespace FaraPayamakRestClient
{
   public interface IFaraPayamakConfiguration
    {
        string Username { get; }
        string Password { get;  }
        string BaseUrl { get; }
        string DefaultNumber { get; }
    }
}
