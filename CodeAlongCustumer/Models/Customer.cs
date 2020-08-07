using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeAlongCustumer.Models
{
    public class Customer
    {
        public string Id { get; set; }
        [Required]
        [StringLength(10, ErrorMessage ="Submitted Name is too long")]
        [DisplayName("Enter your Name")]
        public string Name { get; set; }
        public string Telephone { get; set; }
    }
}