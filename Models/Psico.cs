using Microsoft.AspNetCore.Identity;

namespace JoaoArthur.Models
{
    public class Psico : IdentityUser
    {
        public string? Id { get; set; }
        public string Name { get;set; }
        public string? Crp { get; set; }

    }
}
