namespace Domain.RepositoryPatterns
{
    public interface IRepository<DomainType, IdType> where DomainType : IDomain
    {
        DomainType FindBy(IdType id);
        bool Update(DomainType aggregate);
        IdType Insert(DomainType aggregate);
        bool Delete(DomainType aggregate);
    }
}