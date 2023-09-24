﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Subscribed { get; set; }
    }
}
