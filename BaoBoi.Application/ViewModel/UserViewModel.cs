using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaoBoi.Application.ViewModel
{
    public class UserViewModel : IdentityUser<Guid>
    {
        public int? Level { get; set; } //lv 99: admin
        public DateTime? Dob { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public bool? Remember { get; set; }
    }
}
