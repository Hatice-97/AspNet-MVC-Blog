using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    public class Category //Hem sınıfın kulllandığı model tablosu hem entity sınıfı
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }

        public List<Blog> Bloglar { get; set; }
    }
}