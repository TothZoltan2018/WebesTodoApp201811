using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDoApp.Models
{
    public enum Roles { Fighter, Bomber, Multirole, Recconainsense, Trainer, Transport }
    public class Aircraft
    {
        [Key]
        public int Id { get; set; }
        [Required] public string Type { get; set; } 
        [EnumDataType(typeof(Roles))] public Roles Role { get; set; }
        public int Crew { get; set; }
        public int Range { get; set; }
        public int Speed { get; set; }
        public int Load { get; set; }
        public bool Stealth { get; set; }
     }
}
