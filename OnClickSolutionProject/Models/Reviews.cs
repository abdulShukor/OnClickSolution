using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnClickSolution.Models
{
    public class Reviews
    {

        public int Id { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Text { get; set; }

        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public virtual Products Products { get; set; }

    }
}
