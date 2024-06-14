using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAuth.Data.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
        
        [Required, EmailAddress]
        public string? Email { get; set; }
    }
}

