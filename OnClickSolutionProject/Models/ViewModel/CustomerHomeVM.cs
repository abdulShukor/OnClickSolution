using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnClickSolution.Models.ViewModel
{
    public class CustomerHomeVM
    {
        public List<Products> Products { get; set; }
        public List<Categories> Categories { get; set; }
        public List<SpecialTags> SpecialTags { get; set; }
    }
}
