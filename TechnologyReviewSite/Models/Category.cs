using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TechnologyReviewSite.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        public string Brand { get; set; }
        [DisplayName("Model Number")]
        public string ModelNumber { get; set; }
        public double Price { get; set; }
        public virtual ICollection<Review>Reviews { get; set; }


    }
}