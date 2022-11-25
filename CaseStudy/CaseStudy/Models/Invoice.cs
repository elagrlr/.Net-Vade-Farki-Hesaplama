using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CaseStudy.Models
{
    [Table("Invoices")]
    public class Invoice 
    { 
        public int INVOICEID { get; set; }
        public string AccountNum { get; set; }
        public double InvoiceAmount { get; set; }
        public DateTime? DueDate { get; set; }
        public double BuzOpenAmount { get; set; }
    }
}