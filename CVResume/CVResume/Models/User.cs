using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVResume.Models
{
    public class User : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }

        public virtual List<Education> Educations { get; set; } = new List<Education>();
        public virtual List<Experience> Experiences { get; set; } = new List<Experience>();
        public virtual List<Project> Projects { get; set; } = new List<Project>();
        public virtual List<Skill> Skills { get; set; } = new List<Skill>();
    }
}
