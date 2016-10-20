using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinderSecond.Models
{
    public class PromoCode
    {
        public int Id { get; set; }

        public string Value { get; set; }

        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
    }
}

