using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmsDbAzureApp.Models
{
    public class Basket
    {
        public int Id { get; set; }
        //[ForeignKey("Id")]
        public string Session { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public virtual Film Product { get; set; }
    }
}