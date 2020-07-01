using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingCartApp.DataAccessLayer.Models
{
    public class Customer
    {
        
        public int CustomerId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string mobile { get; set; }
        [Required]
        public string deliveryaddress { get; set; }
        [Required]
        public string billingaddress { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}
