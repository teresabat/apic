using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apic.Models
{
    public class User
    {
        public int Id {get; set;}
        public required string Name {get; set;}
        public required string Email {get; set;}
    }
}