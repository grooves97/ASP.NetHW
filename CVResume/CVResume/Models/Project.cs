using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVResume.Models
{
    public class Project : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }

        public virtual User User { get; set; }
    }
}
