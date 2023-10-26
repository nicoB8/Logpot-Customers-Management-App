namespace logpot.io.customers_management_app.entities.Service
{
    public interface IServiceEntity
    {
        string Id { get; }
        string Name { get; }
        double Price { get; set; }
        bool IsActive { get; }
        DateTime StartDate { get; }
        DateTime EndDate { get; }
    }
}
