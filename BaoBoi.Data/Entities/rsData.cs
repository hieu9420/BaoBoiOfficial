using System;
using System.Collections.Generic;
using System.Text;

namespace BaoBoi.Data.Entities
{
    public class rsData
    {
        public rsData()
        {
            code = 0;
            message = "Successful";
            data = new Dictionary<string, object>();
        }
        public int? code { get; set; }
        public string message { get; set; }
        public Dictionary<string, object> data { get; set; }
    }
}
