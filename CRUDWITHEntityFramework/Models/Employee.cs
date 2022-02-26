using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDWITHEntityFramework.Models
{
    public class Employee
    {
        
        public int ID { get; set; }
        [Required]
        public string  Name{ get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Mobile{ get; set; }
        [Required]
        public string Gender { get; set; }
    }
}
