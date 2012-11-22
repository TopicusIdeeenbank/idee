using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Topicus_Ideeënbank.Models
{
    public class Reactie
    {

        public int ID { get; set; }
        public User user { get; set; }
        public string reactie { get; set; }
        public DateTime datumTijd { get; set; }
        public Reactie reactieTo { get; set; }

    }
}