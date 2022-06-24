using System.ComponentModel.DataAnnotations;

namespace UserRegistrationWithJWt.Models
{
    public class UserModel
    {
        [Key]
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string UserEmail { get; set; }

        public string UserPassword { get; set; }

        public string UserRole { get; set; }

    }
}
