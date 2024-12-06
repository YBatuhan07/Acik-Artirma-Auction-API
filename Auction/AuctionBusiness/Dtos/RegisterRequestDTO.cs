namespace AuctionBusiness.Dtos;

public class RegisterRequestDTO
{
    public string Username { get; set; }
    public string FullName { get; set; }
    public string Password { get; set; }
    public string UserType { get; set; }
}
