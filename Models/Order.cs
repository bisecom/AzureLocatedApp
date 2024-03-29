﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmsDbAzureApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        //[ForeignKey("Id")]
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        //[ForeignKey("Id")]
        public int ClientId { get; set; }

        public virtual Film Product { get; set; }
        public virtual Client Client { get; set; }
    }
}