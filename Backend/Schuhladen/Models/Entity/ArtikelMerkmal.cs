using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Schuhladen.Models.Entity
{
    public class ArtikelMerkmal : IEntity
    {
        public int Id { get; set; }
        public int Artikel_Id { get; set; }
        public int Merkmal_Id { get; set; }
    }
}