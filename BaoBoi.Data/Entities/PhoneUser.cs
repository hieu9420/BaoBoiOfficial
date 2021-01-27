using System;
using System.Collections.Generic;
using System.Text;

namespace BaoBoi.Data.Entities
{
    public class PhoneUser
    {
        public string Phone { get; set; }
        public string Name { get; set; }
        public double? Amount { get; set; }
        public int? Type { get; set; }
        //0: ban be; 1: dong nghiep; 2: xep, 3: thay co,  4: gia dinh, 5: nguoi yeu
        public bool Pay { get; set; }
    }
}
