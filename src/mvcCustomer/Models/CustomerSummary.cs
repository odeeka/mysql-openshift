﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mvcCustomer.Models
{
    public class CustomerSummary
    {
        [Display(Name = "Customer ID")]
        public int Id { get; set; }
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }
    }
}
