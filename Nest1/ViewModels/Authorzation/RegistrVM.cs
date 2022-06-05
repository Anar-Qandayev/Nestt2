using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nest1.ViewModels.Authorzation
{
    public class RegistrVM
    {
        [Required, MaxLength(150)]
        public string Firstname { get; set; }
        [Required, MaxLength(150)]
        public string Lastname { get; set; }
        [Required, MaxLength(150)]
        public string Username { get; set; }
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password), Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}
