using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAuth.Data.Models
{
    public class Students
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int Score {  get; set; }
        public bool Active { get; set; }
        public DateTime DateofBirth { get; set; }
    }
}
