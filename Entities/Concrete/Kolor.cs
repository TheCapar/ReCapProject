using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Kolor:IEntity
    {
        public int KolorId { get; set; }
        public string KolorName { get; set; }

    }
}
