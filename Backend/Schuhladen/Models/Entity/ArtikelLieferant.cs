using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Schuhladen.Models.Entity
{
    public class ArtikelLieferant : IEntity
    {
        public int Id { get; set; }
        public int Artikel_Id { get; set; }
        public int Lieferanten_Id { get; set; }
        public DateTimeOffset LieferDatum { get; set; }
        public decimal Einkaufspreis { get; set; }
        public int Menge { get; set; }
        }
}