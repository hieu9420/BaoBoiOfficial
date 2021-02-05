using System;
using System.Collections.Generic;
using System.Text;

namespace BaoBoi.Application.ViewModel
{
    public class PhoneUserViewModel
    {
        public string Phone { get; set; }
        public string Name { get; set; }
        public double? Amount { get; set; }
        public int? Type { get; set; }
        public bool Pay { get; set; }
    }
}
