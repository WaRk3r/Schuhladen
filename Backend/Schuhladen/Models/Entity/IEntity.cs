using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Schuhladen.Models.Entity
{
    public interface IEntity
    {
        int Id
        {
            get;
            set;
        }
    }
}