using EmployeesMVCApp.Models;

namespace EmployeesMVCApp.Repositories
{
    public class EmployeesRepository : IEmployeesRepository
    {
        private readonly EmployeesContext _employeesContext;
        public EmployeesRepository(EmployeesContext employeesContext)
        {
            _employeesContext = employeesContext;
        }
        public EmployeeModel Get(int EmployeeId)
            => _employeesContext.Employees.SingleOrDefault(x => x.EmployeeId == EmployeeId);

        public IEnumerable<EmployeeModel> GetEmployees()
            => _employeesContext.Employees.Where(x => x.EmployeeId != null);

        public void Add(EmployeeModel employee)
        {
            _employeesContext.Employees.Add(employee);
            _employeesContext.SaveChanges();
        }

        public void Update(int EmployeeId, EmployeeModel employee)
        {
            var result = _employeesContext.Employees.SingleOrDefault(x => x.EmployeeId == EmployeeId);
            if (result != null)
            {
                result.Name = employee.Name;
                result.Lastname = employee.Lastname;
                result.Age = employee.Age;
                result.DateOfHired = employee.DateOfHired;
                result.JobPosition = employee.JobPosition;
                result.PhoneNumber = employee.PhoneNumber;
                result.City = employee.City;
                result.ZIPCode = employee.ZIPCode;
                result.Street = employee.Street;
                result.BuildingNumber = employee.BuildingNumber;
                result.ApartmentNumber = employee.ApartmentNumber;

                _employeesContext.SaveChanges();
            }
        }

        public void Delete(int EmployeeId)
        {
            var result = _employeesContext.Employees.SingleOrDefault(x => x.EmployeeId == EmployeeId);
            if (result != null)
            {
                _employeesContext.Employees.Remove(result);
                _employeesContext.SaveChanges();
            }
        }

    }
}
