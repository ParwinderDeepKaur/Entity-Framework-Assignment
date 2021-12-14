using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Database.Model
{
    public class SaleItem
    {
        /// <summary>
        /// Id (primary key)
        /// </summary>
        [Key]
        public int Id { get; set; }


        /// <summary>
        /// Sale Name
        /// </summary>
        [Required]
        public string SaleName { get; set; }

        /// <summary>
        /// Sale Date
        /// </summary>
        [Required]
        public DateTime SaleDate { get; set; }

        /// <summary>
        /// End Date
        /// </summary>
        [Required]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Price
        /// </summary>
        [Required]
        public string Price { get; set; }

        /// <summary>
        /// Product Id
        /// </summary>
        [ForeignKey("ProductId")]
        public string ProductId { get; set; }

        /// <summary>
        /// Products
        /// </summary>
        public Product Products { get; set; }

    }
}
