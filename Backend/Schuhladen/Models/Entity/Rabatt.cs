using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Schuhladen.Models.Entity
{
    public class Rabatt : IEntity
    {
        public int Id { get; set; }
        public double Prozente { get; set; }
        public DateTimeOffset Von { get; set; }
        public DateTimeOffset Bis { get; set; }
    }
}