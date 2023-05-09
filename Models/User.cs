using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace xUnitMoqDemoApp.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime DateOfCreation { get; set; } = DateTime.Now;
        public int Status { get; set; }
    }
}
