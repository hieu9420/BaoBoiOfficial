using System;
using System.Collections.Generic;
using System.Text;

namespace BaoBoi.Application.Dtos
{
    public class LoginRequest
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool? Remember { get; set; }
    }
}
