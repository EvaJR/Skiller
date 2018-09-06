using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Skiller.Models
{
    public class UserAccount : IdentityUser
    {
        public string Description { get; set; }
        public IList<Skill> Skills { get; set; }
        
    }
}
