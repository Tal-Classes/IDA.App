using System;
using System.Collections.Generic;
using System.Text;

namespace IDA.App.Models
{
    public partial class Location
    {
        public Location()
        {
            Costomers = new List<Costomer>();
            Workers = new List<Worker>();
        }

        public int Lid { get; set; }
        public string City { get; set; }
        public string Adress { get; set; }

        public virtual List<Costomer> Costomers { get; set; }
        public virtual List<Worker> Workers { get; set; }
    }
}
