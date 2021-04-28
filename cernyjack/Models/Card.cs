using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cernyjack.Models
{
    public class Card
    {
        [Key]
        public int Id { get; set; }
        public int Value { get; set; }
    }
}
