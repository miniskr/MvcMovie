using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Display(Name = "名称")]
        public string Title { get; set; }

        [Display(Name = "上映日期")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "分类")]
        public string Genre { get; set; }
        [Display(Name = "价格")]
        public decimal Price { get; set; }
    }
}
