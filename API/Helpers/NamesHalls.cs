using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Helpers
{
    public class NamesHalls
    {
        public string name { get; set; }
         public int idHall { get; set; }

        public NamesHalls(string v1, int v2)
        {
            name = v1;
            idHall = v2;
        }
    }
}