using System.ComponentModel.DataAnnotations;

namespace MyTaxi.Web.Data.Entities
{
    public class TaxiEntity
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Field {0} is mandatory.")]
        [StringLength(6, MinimumLength = 6, ErrorMessage = "The {0} field must have {1} characters.")]
        [RegularExpression(@"^([A-Za-z]{3}\d{3})$", ErrorMessage = "The field {0} must have three characters and three numbers.")]
        public string Plaque { get; set; }
    }
}
