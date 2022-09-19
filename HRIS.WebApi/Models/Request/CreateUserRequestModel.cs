namespace HRIS.WebApi.Models.Request
{
    public class CreateUserRequestModel
    {
        public string? Username { get; set; }
        public string? Nickname { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
        public Guid EmployeeId { get; set; }
        public string? ProfileImage { get; set; }
    }
}
