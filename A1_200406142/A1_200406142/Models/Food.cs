using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace A1_200406142.Models
{
    public class Food
    {
        //this is primary key, it will auto increment. It is used to "mark" our objects, so they will have individual "name"
        public virtual int Id { get; set; }

        public virtual String Name { get; set; }

        public virtual Decimal Price { get; set; }

        public virtual String Description { get; set; }

        public virtual String NutritionalInformation { get; set; }

        public virtual Decimal Weight { get; set; }

        public virtual String Brand { get; set; }

        public virtual String ImageUrl { get; set; }

        [DisplayName("Сreated for")]
        public virtual String TypeOfAnimal { get; set; }

        
        public virtual int AnimalId { get; set; }
        //this is foreign key, it connects variable from one class to another one.
        [DisplayName("Animal Description")]
        public virtual Animal AnimalType { get; set; }

    }
}
