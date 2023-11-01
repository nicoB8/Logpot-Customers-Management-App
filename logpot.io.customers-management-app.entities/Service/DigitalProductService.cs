namespace logpot.io.customers_management_app.entities.Service
{
    public class DigitalProductService : ServiceEntity
    {
        public DigitalProductService() { }

        public DigitalProductService(DigitalProductType productType, double price, DateTime startDate, DateTime endDate) : base(DigitalProductTypeValue.GetDigitalProductType(productType), price, startDate, endDate)
        {
        }

        public int MonthlyLimit { get; set; }
        public int MonthConsumption { get; set; }
    }
}
