using logpot.io.customers_management_app.dto.BaseDTO;
using logpot.io.customers_management_app.entities.BaseEntity;

namespace logpot.io.customers_management_app.business_logic.BaseLogic
{
    public interface IBaseLogic<DAO, DTO>
        where DAO : IBaseEntity
        where DTO : IBaseDTO
    {
        public DAO Create(DTO dto);
        public Task<DAO> Get(string id);
        public IEnumerable<DAO> GetAll();
    }
}
