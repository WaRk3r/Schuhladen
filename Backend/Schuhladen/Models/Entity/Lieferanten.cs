using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Schuhladen.Models.Entity
{
    public class Lieferanten : IEntity
    {
        public int Id { get; set; }
        public int Adresse_Id { get; set; }
        public string Name { get; set; }
    }
}