using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace movie.data.Entities;

public class ApplicationUser : IdentityUser
{
    public ApplicationUser()
    {
        Id = Guid.NewGuid().ToString();

        Roles = new HashSet<IdentityUserRole<string>>();
        Claims = new HashSet<IdentityUserClaim<string>>();
        Logins = new HashSet<IdentityUserLogin<string>>();

        UsersMovies = new HashSet<UserMovie>();
    }

    [Required] public string Country { get; set; }

    [Required] public string City { get; set; }

    public ICollection<UserMovie> UsersMovies { get; set; }

    public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }

    public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }

    public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }
}