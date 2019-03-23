using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnClickSolution.Models
{
    public class Products
    {

        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public double OriginalPrice { get; set; }
        public double PromotionalPrice { get; set; }

        public bool Available { get; set; }
        public string Image { get; set; }

        public string Color { get; set; }

        [Display(Name = "Product Type")]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Categories Categories { get; set; }

        [Display(Name = "Speical Tag")]
        public int? SpecialTagsID { get; set; }

        [ForeignKey("SpecialTagsID")]
        public virtual SpecialTags SpecialTags { get; set; }

    }
}
