using App.Project.Models;

namespace App.Project.Infstracter
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
