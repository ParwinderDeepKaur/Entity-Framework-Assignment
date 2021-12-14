using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Database.Model
{
    public class Product
    {
        /// <summary>
        /// Id (primary key)
        /// </summary>
        [Key]
        public int Id { get; set; }


        /// <summary>
        /// Name
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [Required]
        public string Description { get; set; }


        /// <summary>
        /// Price
        /// </summary>
        [Required]
        public string Price { get; set; }
    }
}
