using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetcore_angular_project.Entities
{
    public class AppUser
    {
        [Key]
        public int Id { get; set; }

        public string Username { get; set; }
    }
}
