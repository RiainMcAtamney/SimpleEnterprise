using System;
using System.Collections.Generic;

namespace MySample.Business
{
    public class Company
    {
       
        public int Id { get; set; }

        public string Name { get; set; }

       
        public string Location { get; set; }

        public string newStringField { get; set; }

        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }

        public virtual List<Product> Products { get; set; }

        public Company()
        {
            DateCreated = DateTime.Now;
        }
    }
}
