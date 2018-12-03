using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoApp.Models
{
    /// <summary>
    /// Egy ideiglenes barkacs "adatbazis"
    /// ami kiszolgalja a webszerver alaklmazasunkat
    /// tanulasi/tesztelesi idoben
    /// </summary>
    public class MyDb
    {
        public static List<TodoItem> Lista = new List<TodoItem> //a lista publikus, eyert konvencio szerint nagybetusse atneveztuk
            {
                new TodoItem() { Name = "Só", Done = true },
                new TodoItem() { Name = "Cukor", Done = true },
                new TodoItem() { Name = "Spagetti", Done = true },
                new TodoItem() { Name = "Marhahús", Done = false },
                new TodoItem() { Name = "Paradicsom", Done = false }
            };

    }
}