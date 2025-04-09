namespace WebApplication1.Model
{
    public interface IEmployeerRepository
    {
        void Add(Employee employee);

        List<Employee> Get();

        Employee? Get(int id);
    }
}
