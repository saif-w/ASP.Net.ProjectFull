using APP.Project.DataAccess.Data.Tabels;
using AutoMapper;
using Models.Models;

namespace APP.Project.Buisness.Mapping
{
    public class EmployeeMapping:Profile
    {
        public EmployeeMapping()
        {
            CreateMap< EmployeeModels, Employees>();
        }
    }
}
