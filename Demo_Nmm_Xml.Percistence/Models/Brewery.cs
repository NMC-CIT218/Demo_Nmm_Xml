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

        public string Address { get;  set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }
        
        [Required]
        [RegularExpression(@"/^(https?:\/\/)?([\da-z\.-]+)\.([a-z\.]{2,6})([\/\w \.-]*)*\/?$/", 
            ErrorMessage = "Please enter a valid URL")]
        public string Phone { get; set; }

        public string URL { get; set; }

        public string ContactEmail { get; set; }

    }
}