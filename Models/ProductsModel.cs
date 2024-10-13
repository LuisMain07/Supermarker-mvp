using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SupermarkerDefinitive.Models
{
    internal class ProductsModel
    {
        [DisplayName("Products Id")]
        public int Id { get; set; }

        [DisplayName("Products Name")]
        [Required(ErrorMessage = "Name is required")]
        [StringLength(80, MinimumLength = 3, ErrorMessage = "Product Name must be between 3 and 80 characteres")]

        public string Name { get; set; }

        [DisplayName("Products Price")]
        [Required(ErrorMessage = "Price is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Product Price must be between 3 and 50 characteres")]
        public string Price { get; set; }

        [DisplayName("Products Stock")]
        [Required(ErrorMessage = "Stock is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Product Stock must be between 3 and 50 characteres")]
        public string Stock { get; set; }

        [DisplayName("Products Category_id")]
        [Required(ErrorMessage = "Category_id is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Product Category_id must be between 3 and 50 characteres")]
        public string Category_id { get; set; }
    }
}
