using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVResume.Models
{
    public class Education : Entity
    {
        public string Faculty { get; set; }
        public string Profession { get; set; }

        public virtual User User { get; set; }
    }
}
