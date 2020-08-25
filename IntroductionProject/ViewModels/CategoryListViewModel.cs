using IntroductionProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntroductionProject.ViewModels
{
    public class CategoryListViewModel
    {
        // Display List of All Product within One Category
        public Category Category { get; set; }
        public IEnumerable<Product> Product { get; set; }

        //public int CategoryId { get; set; }
        //public int CategoryName { get; set; }

        // List of Products
        //List<Product> Product { get; set; }
    }
}