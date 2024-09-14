using LearningCQRSinAspNetCoreUsingMediatR.Models;

namespace LearningCQRSinAspNetCoreUsingMediatR.Data
{
    public interface IEmployeeService
    {
        void AddEmployee(EmployeeDto employee);
        EmployeeDto GetEmployee(Guid id);
        IEnumerable<EmployeeDto> GetEmployees();
    }
}
