using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Topicus_Ideeënbank.Models
{
    public class Kudo
    {
        public int ID { get; set; }
        public User user { get; set; }
        public bool goodBad { get; set; }

    }
}