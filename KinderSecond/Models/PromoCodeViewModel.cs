using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KinderSecond.Models
{
    public class PromoCodeViewModel
    {
        [Required(ErrorMessage = "The Value is required")]
        [RegularExpression(@"^[A-F0-9]{40}$", ErrorMessage = "Валидни дати 1-31 като едноцифрените 1-9 може да имат 0 отпред")]
        public string Value { get; set; }
    }
}