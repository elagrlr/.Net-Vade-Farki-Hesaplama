using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaseStudy.Models
{
    public class Delay
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public int PaymentId { get; set; }
        public string AccountNum{ get; set; }
        public double Rate { get; set; }
        public double delayAmount { get; set; }
    }
}
