using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmsDbAzureApp.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }
        public string Production { get; set; }
        public string Country { get; set; }
        public string Year { get; set; }
        public string Cast { get; set; }
        public byte[] Picture { get; set; }
        public int Price { get; set; }
    }
}