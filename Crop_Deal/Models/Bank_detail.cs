using System.ComponentModel.DataAnnotations;

namespace Crop_Deal.Models
{
    public class Bank_detail
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter your Bank Name")]
        public string? Bank_name { get; set; }

        //-------------------------------------------------------------

        [Required(ErrorMessage = "Please enter your Bank Account number")]
        public string? Account_no { get; set; }

        //-------------------------------------------------------------

        [Required(ErrorMessage = "Please enter  IFSC code")]
        public string? IFSC { get; set; }

    }
}
