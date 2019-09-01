using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Toro.API.Models
{
    [Table("User")]
    public class User : ModelBase
    {
        [Required]
        public string UserName { get; set; }

        //public string Email { get; set; }
        [Required]
        public byte[] PasswordHash { get; set; }

        [Required]
        public byte[] PasswordSalt { get; set; }

        public DateTime Created { get; set; }
        public DateTime? LastActive { get; set; }
    }
}
