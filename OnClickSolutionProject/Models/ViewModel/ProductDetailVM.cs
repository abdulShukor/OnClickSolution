using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnClickSolution.Models.ViewModel
{
    public class ProductDetailVM
    {
        public Products Product { get; set; }
        public List<Reviews> Reviews { get; set; }
    }
}
