using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace DatabaseSaveFile
{
    public class Rhysindb
    {
        [PrimaryKey, AutoIncrement]
        public int ItemNum { get; set; }
        public string Desc { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Subtotal { get; set; }

    }
}
