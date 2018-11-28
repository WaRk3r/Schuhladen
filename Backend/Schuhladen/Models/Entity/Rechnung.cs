using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Schuhladen.Models.Entity
{
    public class Rechnung : IEntity
    {
        public int Id { get; set; }
        public DateTimeOffset Datum { get; set; }
    }
}