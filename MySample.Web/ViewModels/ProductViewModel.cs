using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySample.Web.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CompanyId { get; set; }

        public string Image { get; set; }

    }
}