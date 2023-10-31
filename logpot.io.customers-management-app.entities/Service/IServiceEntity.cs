using logpot.io.customers_management_app.entities.BaseEntity;

namespace logpot.io.customers_management_app.entities.Service
{
    public interface IServiceEntity : IBaseEntity
    {
        string Name { get; }
        double Price { get; set; }
        bool IsActive { get; }
        DateTime StartDate { get; }
        DateTime EndDate { get; }
    }
}
