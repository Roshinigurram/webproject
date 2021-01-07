using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace project1.Models
{
    [Table("Department")]
    public class Department
    {
        public int id { get; set; }
        public string name { get; set; }
        public string loc   { get; set; }
    }
}
