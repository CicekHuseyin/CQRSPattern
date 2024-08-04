namespace Inspimo.CQRSPattern.CQRSPattern.Results
{
    public class GetProductQueryResult
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string ProductBrand { get; set; }
        public int ProductStock { get; set; }
        public decimal ProductPrice { get; set; }
        public bool ProductStatus { get; set; }
    }
}
