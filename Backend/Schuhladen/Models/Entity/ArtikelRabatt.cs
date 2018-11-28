using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Schuhladen.Models.Entity
{
    public class ArtikelRabatt : IEntity
    {
        public int Id { get; set; }
        public int Artikel_Id { get; set; }
        public int Rabatt_Id { get; set; }
    }
}