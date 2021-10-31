﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IDA.App.Models
{
    public partial class Location
    {
        public Location()
        {
            Costomers = new HashSet<Costomer>();
            Workers = new HashSet<Worker>();
        }

        public int Lid { get; set; }
        public string City { get; set; }
        public string Adress { get; set; }

        public virtual ICollection<Costomer> Costomers { get; set; }
        public virtual ICollection<Worker> Workers { get; set; }
    }
}
