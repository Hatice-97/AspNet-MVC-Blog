using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    public class BlogInitializer:DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> kategoriler = new List<Category>()
            {
                new Category() {KategoriAdi="Otomobil Haberleri"},
                new Category() {KategoriAdi="Araba Fiyatları"},
                new Category() {KategoriAdi="Güvenlik"},
                new Category() {KategoriAdi="Sigorta ve Kasko"},
            };

            foreach (var item in kategoriler)
            {
                context.Kategoriler.Add(item);
            }
            context.SaveChanges();

            List<Blog> bloglar = new List<Blog>()
            {
                new Blog() {Baslik="Otomobil Haberleri Hakkında", Aciklama="Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-20), Anasayfa=true, Onay=true, Icerik="Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında", Resim="1.jpg", CategoryId=1 },
                new Blog() {Baslik="Otomobil Haberleri Hakkında", Aciklama="Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-20), Anasayfa=true, Onay=true, Icerik="Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında", Resim="1.jpg", CategoryId=1 },
                new Blog() {Baslik="Otomobil Haberleri Hakkında", Aciklama="Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=false, Onay=true, Icerik="Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında", Resim="2.jpg", CategoryId=2 },
                new Blog() {Baslik="Otomobil Haberleri Hakkında", Aciklama="Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-20), Anasayfa=true, Onay=false, Icerik="Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında", Resim="2.jpg", CategoryId=2 },
                new Blog() {Baslik="Otomobil Haberleri Hakkında", Aciklama="Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-30), Anasayfa=true, Onay=true, Icerik="Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında", Resim="2.jpg", CategoryId=3 },
                new Blog() {Baslik="Otomobil Haberleri Hakkında", Aciklama="Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-20), Anasayfa=false, Onay=true, Icerik="Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında", Resim="2.jpg", CategoryId=3 },
                new Blog() {Baslik="Otomobil Haberleri Hakkında", Aciklama="Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true, Onay=false, Icerik="Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında", Resim="3.jpg", CategoryId=4 },
                new Blog() {Baslik="Otomobil Haberleri Hakkında", Aciklama="Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-25), Anasayfa=false, Onay=true, Icerik="Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında Otomobil Haberleri Hakkında", Resim="3.jpg", CategoryId=4 },
            };

            foreach(var item in bloglar)
            {
                context.Bloglar.Add(item);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}