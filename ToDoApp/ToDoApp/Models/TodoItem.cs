﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//A Model mapan job klikkel adtuk hozza ezt az osztalyt
namespace ToDoApp.Models
{
    public class TodoItem
    {
        public string Name { get; internal set; }
        public bool Done { get; internal set; }
    }
}