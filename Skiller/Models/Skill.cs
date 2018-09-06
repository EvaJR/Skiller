using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Skiller.Models
{
    public class Skill
    {
        [Key]
        public int ID { get; set; }
        public string Description { get; set; }
        public Level Level { get; set; }
        public UserAccount UserAccount { get; set; }
        public string UserAccountId { get; set; }  // what does this do??

    }

    public enum Level { Noob, Novice, Intermediate, Advanced, Guru };
}
