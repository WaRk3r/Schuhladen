using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Schuhladen.Models.Entity
{
    public class Verkaufspreis : IEntity
    {
        public int Id { get; set; }

        public int Artikel_Id { get; set; }

        public decimal Preis { get; set; }
        public DateTimeOffset AbDatum { get; set; }
    }
}