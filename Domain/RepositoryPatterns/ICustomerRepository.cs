namespace Domain.RepositoryPatterns
{
    public interface ICustomerRepository : IRepository<Customer, int>
    {
        Customer FindByName(string nameToSearch);
    }
}