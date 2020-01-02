using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperHeros.Models
{
    public class SuperHero
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string alterEgo { get; set; }
        public string primarySuperheroAbility { get; set; }
        public string secondarySuperheroAbility { get; set; }
        public string catchpharse { get; set; }
    }
}