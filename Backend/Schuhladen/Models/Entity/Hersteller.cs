using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Schuhladen.Models.Entity
{
    public class Hersteller : IEntity
    {
        public int Id { get; set; }
        public string Bezeichnung { get; set; }
    }
}