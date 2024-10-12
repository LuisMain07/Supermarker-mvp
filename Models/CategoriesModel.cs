using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SupermarkerDefinitive.Models
{
    internal class CategoriesModel
    {
        [DisplayName("Categories Id")]
        public int Id { get; set; }

        [DisplayName("Categories Name")]
        [Required(ErrorMessage = "Name is required")]
        [StringLength(80, MinimumLength = 3, ErrorMessage = "Categories Name must be between 3 and 80 characteres")]

        public string Name { get; set; }

        [DisplayName("Categories Description")]
        [Required(ErrorMessage = "Description is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Categories Description must be between 3 and 200 characteres")]
        public string Description { get; set; }

    }
}
