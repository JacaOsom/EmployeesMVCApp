using EmployeesMVCApp.Models;

namespace EmployeesMVCApp.Repositories
{
    public interface IEmployeesRepository
    {
        EmployeeModel Get(int EmployeeId);
        IEnumerable<EmployeeModel> GetEmployees();
        void Add(EmployeeModel employee);
        void Update(int EmployeeId, EmployeeModel employee);
        void Delete(int EmployeeId);
    }
}
