using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CaseStudy.Models
{

    [Table("Payments")]
    public class Payment
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public string Bank { get; set; }
        public double PaymentAmount { get; set; }
        public string AccountNum { get; set; }
        public DateTime? TransDate { get; set; }
    }

}