using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Schuhladen.Models.Entity
{
    public class Adresse : IEntity
    {
        public int Id { get; set; }
        public int Ort_Id { get; set; }
        public string Straße { get; set; }
        public string Hausnummer { get; set; }
    
    }
}