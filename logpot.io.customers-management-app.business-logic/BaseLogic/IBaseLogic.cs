namespace logpot.io.customers_management_app.business_logic.BaseLogic
{
    public interface IBaseLogic<DAO, DTO>
        where DAO : class
        where DTO : class
    {
        public DAO Create(DTO dto);
        public Task<DAO> Get(string id);
        public IEnumerable<DAO> GetAll();
    }
}
