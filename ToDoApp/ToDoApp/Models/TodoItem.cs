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
        [Required]
        public string Name { get; set; } //internal set: nem beviteli, csak megjelenito mezo... A todo2Controller varazsloja e miatt csinalta nem modosithatova a Crate es Edit lapokon a form mezoit
        public bool Done { get;  set; }
    }
} 