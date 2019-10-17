using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PetFood_Store.Models
{
    public class Food
    {

        public virtual int Id { get; set; }


        public virtual String Name { get; set; }

        public virtual Decimal Price { get; set; }

        public virtual String Description { get; set; }

        public virtual String NutritionalInformation { get; set; }

}
}
