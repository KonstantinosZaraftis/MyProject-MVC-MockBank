using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyProject.Models
{
    public class BankAccount
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        [Display(Name = "Account Number")]
        public string AccountNumber { get; set; }
        public ApplicationUser Customer { get; set; }

       // public Customer Customer { get; set; }
       
    }
}