using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Topicus_Ideeënbank.Models
{
    public class User
    {
        public int ID { get; set; }
        public string naam { get; set; }
        public string email { get; set; }
        public string omschrijving { get; set; }
    }
}