using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Schuhladen.Models.Entity
{
    public class Merkmal : IEntity
    {
        public int Id { get; set; }
        public double Groese { get; set; }
        public string Farbe { get; set; }
        public string Typ { get; set; }
    }
}