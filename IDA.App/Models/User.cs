using System;
using System.Collections.Generic;
using System.Text;

namespace IDA.App.Models
{
    public partial class User
    {
        public User()
        {
            Costomers = new List<Costomer>();
            Workers = new List<Worker>();
        }

        public string UserName { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserPswd { get; set; }
        public string Adress { get; set; }
        public bool IsWorker { get; set; }

        public virtual List<Costomer> Costomers { get; set; }
        public virtual List<Worker> Workers { get; set; }
    }
}
