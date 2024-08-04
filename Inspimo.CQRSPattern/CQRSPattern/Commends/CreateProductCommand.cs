﻿namespace Inspimo.CQRSPattern.CQRSPattern.Commends
{
    public class CreateProductCommand
    {
        public string ProductName { get; set; }
        public string ProductBrand { get; set; }
        public int ProductStock { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
