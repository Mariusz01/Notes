using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Notes.Models
{
    class Note
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Text { get; set; }
        public string Numer { get; set; }
//        public int Numer { get; set; }
    }
}
