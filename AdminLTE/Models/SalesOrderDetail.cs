﻿namespace AdminLTE.Models
{
    public class SalesOrderDetail
    {
        public int sr { get; set; }
        public string Ordertracknumber { get; set; }
        public int quantity { get; set; }
        public string productname { get; set; }
        public string specialoffer { get; set; }
        public double unitprice { get; set; }
        public double unitpricediscount { get; set; }
    }
}
