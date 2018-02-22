using System.ComponentModel.DataAnnotations;

namespace Demo_Nmm_Xml.Models
{
    public class Brewery
    {
        [Required(ErrorMessage = "A unique Id must be entered.")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Brewery Name")]
        public string Name { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        [RegularExpression(@"\(?\d{3}\)?[. -]? *\d{3}[. -]? *[. -]?\d{4}", ErrorMessage = "Please enter a valid phone number.")]
        public string Phone { get; set; }

        [Required]
        [RegularExpression(@"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)?[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$", ErrorMessage = "Please enter a valid URL")]
        public string URL { get; set; }
    }
}