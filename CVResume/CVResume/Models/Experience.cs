using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVResume.Models
{
    public class Experience : Entity
    {
        public string ExWorkPosition { get; set; }
        public string CompanyName { get; set; }

        public virtual User User { get; set; }
    }
}
