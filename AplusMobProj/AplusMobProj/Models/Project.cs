using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace AplusMobProj.Models
{
    public class Project
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string NameProject { get; set; }
        public string Description { get; set; }
        public string NumberPhone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
