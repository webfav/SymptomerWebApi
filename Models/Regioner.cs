using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SymptomerWebApi.Models
{
    public class Regioner
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //public virtual List<Symptomer> Symptomer { get; set; }

    }
}
