using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookshelf.Models
{
    public class Book
    {
        [Key] //primary key//
        public int ID { get; set; } //When you are building a model in C#, you will always want an ID//
        public string Title { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }

        [ForeignKey("Category")] //ForeignKey establishes relationship with another class (or table)//
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; } //"Category Category" is navigation property//
    }
}