using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Brands : IEntity
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
    }
}
