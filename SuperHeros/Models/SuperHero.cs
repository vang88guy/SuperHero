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
        [Display(Name = "Alter Ego")]
        public string alterEgo { get; set; }
        [Display(Name = "Primary Ability")]
        public string primarySuperheroAbility { get; set; }
        [Display(Name = "Secondary Ability")]
        public string secondarySuperheroAbility { get; set; }
        [Display(Name = "Catchpharse")]
        public string catchpharse { get; set; }
    }
}