
using Models.Models;

namespace APP.Project.Buisness.Infstracter
{
    public interface IEmployeesServices
    {
        IEnumerable<EmployeeGridView> GetEmployees();
        EmployeeModels GetEmployees(int id);
        void Add(EmployeeModels employee);
        void Update(int id, EmployeeModels employee);
        void Delete(int id);
    }

}
