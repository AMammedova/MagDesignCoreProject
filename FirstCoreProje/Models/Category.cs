using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreProje.Models
{
    public class Category:Entity
    {
        public string Name { get; set; }
        public int ParentId { get; set; }
       
    }
}
