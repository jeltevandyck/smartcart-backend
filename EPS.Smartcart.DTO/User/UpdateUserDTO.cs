namespace EPS.Smartcart.DTO.User;

public class UpdateUserDTO
{
    public string Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public DateTime? BirthDate { get; set; }
}