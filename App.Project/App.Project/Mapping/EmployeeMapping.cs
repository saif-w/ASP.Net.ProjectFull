using App.Project.Data.Tabels;
using App.Project.Models;
using AutoMapper;

namespace App.Project.Mapping
{
    public class EmployeeMapping:Profile
    {
        public EmployeeMapping()
        {
            CreateMap< EmployeeModels, Employees>();
        }
    }
}
