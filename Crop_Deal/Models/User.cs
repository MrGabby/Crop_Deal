using System.ComponentModel.DataAnnotations;

namespace Crop_Deal.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        //-----------------------------------------------------------------
        [Required(ErrorMessage = "Please enter your name"), MinLength(3), MaxLength(50)]
        public string? Name { get; set; }

        //----------------------------------------------------------------- 
        [Required(ErrorMessage = "Please enter contact number")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Contact Number")]
        public string? Contact { get; set; }

        public string? Roles { get; set; } = string.Empty;

        //-----------------------------------------------------------------
        [Required(ErrorMessage = "Please enter your email id")]
        [DataType(DataType.EmailAddress)]

        public string? Email_id { get; set; }

        //-----------------------------------------------------------------

/*        [Required]
        public byte[]? PasswordHash { get; set; }
        [Required]
        public byte[]? PasswordSalt { get; set; }*/
        [Required]
        public int Password { get; set; }


        //-------------------------------------------------------------

        [Required(ErrorMessage = "Please enter your Address")]
        public string? Address { get; set; }


        //-------------------------------------------------------------

        public bool Is_subscribe { get; set; } = false;

        public bool Is_Active { get; set; } = false;

    }
}

