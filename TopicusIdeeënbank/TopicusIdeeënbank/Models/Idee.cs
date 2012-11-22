using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Topicus_Ideeënbank.Models
{
    public class Idee
    {
        public int ID { get; set; }
        public string titel { get; set; }
        public string omschrijving { get; set; }
        public User user { get; set; }
        public List<Kudo> kudos { get; set; }
        public bool active { get; set; }
        public List<Reactie> reacties { get; set; }

    }
}