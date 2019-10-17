using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace A1_200406142.Models
{
    public class Animal
    {

        public Animal()
        {


        }
        public Animal (int AnimalId, String Name,String Description)
        {
            this.AnimalId = AnimalId;
            this.Name = Name;
            this.Description = Description;


        }

        //this is primary key, it will auto increment. It is used to "mark" our objects, so they will have individual "name"
        [Key]
        public virtual int AnimalId { get; set; }


        //anywhere that we have this property displayed, it's gonna automatically use that string instead of just variable
        [DisplayName("Animal Name")]
        [Required]
        public virtual String Name { get; set; }

        //limits Description variable to be more than 200 signs.
        [Required]
        [StringLength(200)]
        public virtual String Description { get; set; }

        public virtual List<Food> Foods { get; set; }


    }
}
