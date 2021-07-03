using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyProject.Models
{
    public class BankAccount
    {
        [ForeignKey("Card")]
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        [Display(Name = "Account Number")]
        public string AccountNumber { get; set; }
        public  virtual Card Card { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }


    }
}