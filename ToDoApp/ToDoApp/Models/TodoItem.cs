using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

//A Model mapan job klikkel adtuk hozza ezt az osztalyt
namespace ToDoApp.Models
{
    public class TodoItem
    {
        [Key] //az Id lesz az adatbazisban a kulcs mezo
        public int Id { get; set; }
        public string Name { get; internal set; }
        public bool Done { get; internal set; }
    }
} 