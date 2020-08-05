using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq; 
using System.Web;

namespace MyProject.Models
{
    public class Customer
    {
        
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        [Display(Name = "Last Name")]
        public String LastName { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]

       
        public string Address { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
         public int? CardId { get; set; }
         public Card Card { get; set; }// exei mia karta
         public IEnumerable<BankAccount> BankAccounts { get; set; }// exei pollous logariasmous
       


    }
}