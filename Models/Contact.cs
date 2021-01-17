using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Empty contact name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Empty phone number")]
        [RegularExpression(@"[0-9]{11}|\+[0-9]{12}" , ErrorMessage = "invalid phone number")]
        public string MobilePhone { get; set; }
        [RegularExpression(@"(Mr\.|Mrs\.|Miss|Ms\.)", ErrorMessage = "use smth like: Mr., Mrs., Miss, Ms")]
        public string Dear { get; set; }
        [StringLength(50, ErrorMessage = "Длина строки должна быть до 50 символов")]
        public string JobTitle { get; set; }
        [RegularExpression(@"([0-9]{2}\.[0-9]{2}\.[0-9]{4})", ErrorMessage = "invalid date, plese use DD.MM.YYYY format")]
        public string BirthDate { get; set; }


    }
}
