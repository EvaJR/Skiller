using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Skiller.Models
{
    public class SkillLevelViewModel
    {

        public List<Skill> skills;
        public SelectList levels; // wat is een selectlist?
        public string skillLevel { get; set; }
    }
}
