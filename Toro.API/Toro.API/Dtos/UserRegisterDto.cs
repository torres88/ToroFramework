using System;
using System.ComponentModel.DataAnnotations;

namespace Toro.API.Dtos
{
    public class UserRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "A jelszónak legalább 8 hosszúnak kell lennie.")]
        public string Password { get; set; }

        //[Required]
        //public string Gender { get; set; }

        //[Required]
        //public string KnownAs { get; set; }

        //[Required]
        //public DateTime DateOfBirth { get; set; }

        //[Required]
        //public string City { get; set; }

        //[Required]
        //public string Country { get; set; }
        public DateTime Created { get; set; }
        public DateTime? LastActive { get; set; }

        public UserRegisterDto()
        {
            Created = DateTime.Now;
            //LastActive = DateTime.Now;
        }
    }
}