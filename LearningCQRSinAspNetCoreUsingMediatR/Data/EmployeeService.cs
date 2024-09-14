using LearningCQRSinAspNetCoreUsingMediatR.Models;

namespace LearningCQRSinAspNetCoreUsingMediatR.Data
{
    public class EmployeeService : IEmployeeService
    {
        private List<EmployeeDto> employees = [];

        public void AddEmployee(EmployeeDto employee)
        {
            employee.Id = Guid.NewGuid();
            employees.Add(employee);
        }

        public IEnumerable<EmployeeDto> GetEmployees()
        {
            return employees;
        }

        public EmployeeDto GetEmployee(Guid id)
        {
            return employees.FirstOrDefault(e => e.Id == id);
        }
    }
}
