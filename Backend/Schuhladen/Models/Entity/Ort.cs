using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Schuhladen.Models.Entity
{
    public class Ort : IEntity
    {
        public int Id { get; set; }
        public int PLZ { get; set; }
        public string Name { get; set; }
    }
}