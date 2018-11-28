using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Schuhladen.Models.Entity
{
    public class Artikel : IEntity
    {
        public int Id { get; set; }
        public int Hersteller_Id { get; set; }
        public float EAN { get; set; }
        public string Bezeichnung { get; set; }
        public int Menge { get; set; }
    }
}