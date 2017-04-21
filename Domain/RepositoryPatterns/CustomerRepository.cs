using System;

namespace Domain.RepositoryPatterns
{
    public class CustomerRepository : ICustomerRepository
    {
        public Customer FindByName(string nameToSearch)
        {
            throw new NotImplementedException();
        }

        public Customer FindBy(int id)
        {
            var customer = new Customer();
            customer.Name = "Clare";
            return customer;
        }

        public bool Update(Customer aggregate)
        {
            throw new NotImplementedException();
        }

        public int Insert(Customer aggregate)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Customer aggregate)
        {
            throw new NotImplementedException();
        }
    }
}