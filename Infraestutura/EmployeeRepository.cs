using WebApplication1.Model;

namespace WebApplication1.Infraestutura
{
    public class EmployeeRepository : IEmployeerRepository
    {

        private readonly ConnectionContext _context = new ConnectionContext();

        public void Add(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
    }

        public List<Employee> Get()
        {
            return _context.Employees.ToList();
        }

        public Employee? Get(int id)
        {
            return _context.Employees.Find(id);
        }
    }

   
}
