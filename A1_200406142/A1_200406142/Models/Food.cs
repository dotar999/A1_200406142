using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A1_200406142.Models
{
    public class Food
    {

        public virtual int Id { get; set; }

        public virtual String Name { get; set; }

        public virtual Decimal Price { get; set; }

        public virtual String Description { get; set; }

        public virtual String NutritionalInformation { get; set; }

        public virtual Decimal Weight { get; set; }

        public virtual String Brand { get; set; }

        public virtual String TypeOfAnimal { get; set; }

    }
}
