using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using static CaseStudy.Models.Payment;

namespace CaseStudy.Models
{
    public class EntityListViewModel
    {
        [Key]
        public int Id { get; set; }
        public Invoice Invoices { get; set; }
        public Payment Payments { get; set; }
        public Delay Delays { get; set; }
    }
}