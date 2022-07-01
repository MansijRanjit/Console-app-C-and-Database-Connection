using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppxyz.models
{
    public class Students
    {
        public int Id { get; set; }
        [StringLength(50)] public string name { get; set; }
        public string phoneno { get; set; }
        [StringLength(50)] public string email { get; set; }
    }
}