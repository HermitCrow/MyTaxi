using System.ComponentModel.DataAnnotations;

namespace MyTaxi.Web.Data.Entities
{
    public class TaxiEntity
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Field {0} is mandatory.")]
        [StringLength(7, MinimumLength = 7, ErrorMessage = "The {0} field must have {1} characters.")]
        [RegularExpression(@"^([A-Za-z]{1}\d{6})$", ErrorMessage = "The field {0} must have one characters and six numbers.")]
        public string Plaque { get; set; }
    }
}
