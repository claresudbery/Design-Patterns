namespace Domain.RepositoryPatterns
{
    public class Customer : IDomain
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address2 Address { get; set; }
    }
}