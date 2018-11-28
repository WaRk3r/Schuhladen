using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Schuhladen.Models.Entity
{
    public class Bestelleung : IEntity
    {
        public int Id { get; set; }
        public int Lieferanten_Id { get; set; }
    }
}