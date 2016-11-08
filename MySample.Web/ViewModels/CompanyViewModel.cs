using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySample.Web.ViewModels
{
    public class CompanyViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<ProductViewModel> Products { get; set; }

    }
}