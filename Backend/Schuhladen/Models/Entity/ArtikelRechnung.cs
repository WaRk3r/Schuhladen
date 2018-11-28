using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Schuhladen.Models.Entity
{
    public class ArtikelRechnung : IEntity
    {
        public int Id { get; set; }
        public int Artikel_Id { get; set; }
        public int Rechnung_id { get; set; }
        public int Menge { get; set; }

    }
}