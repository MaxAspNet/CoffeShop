﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aprel.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public string Person { get; set; }
        public string Adress { get; set; }
        public int ItemId { get; set; }
        public DateTime Date { get; set; }
    }
}