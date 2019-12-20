using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVResume.Models
{
    public class Skill : Entity
    {
        public string SkillName { get; set; }

        public virtual User User { get; set; }
    }
}
