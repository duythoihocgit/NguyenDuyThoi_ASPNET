using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NguyenDuyThoi_2122110066.Context;

namespace NguyenDuyThoi_2122110066.Models
{
    public class HomeModel
    {
        public List<Product> ListProduct { get; set; }
        public List<Category> ListCategory { get; set; }
    }
}