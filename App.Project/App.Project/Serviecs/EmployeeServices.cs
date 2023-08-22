using App.Project.Data.Tabels;
using App.Project.Data;
using App.Project.Infstracter;
using App.Project.Models;
using AutoMapper;

namespace App.Project.Serviecs
{
    public class EmployeeServices:IEmployeesServices
    {
        private readonly HRDBContext _context;
        private readonly IMapper _mapper;
        public EmployeeServices(HRDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
      
        public void Add(EmployeeModels employee)
        {
            if (employee == null)
                throw new ArgumentNullException("الرجاء التأكد من ادخال البيانات");
            var employeeData = _mapper.Map<Employees>(employee);

            _context.Employees.Add(employeeData);
            _context.SaveChanges();

        }

        public void Delete(int id)
        {
            if (id == 0)
                throw new ArgumentNullException("خطاء في ادخال البيانات");
            var Employeedata = _context.Employees.Find(id);
            _context.Employees.Remove(Employeedata);
            _context.SaveChanges();

        }

        public IEnumerable<EmployeeGridView> GetEmployees()
        {


            IQueryable<Employees> employeedata = from x in _context.Employees select x;

            var data = (from p in employeedata
                        select new EmployeeGridView
                        {
                            Birthdate = p.Birthdate,
                            FullName = p.FullName,
                            Id = p.Id,
                        }).ToList();

            return data;
        }

        public EmployeeModels GetEmployees(int id)
        {
            if (id == 0) throw new ArgumentNullException("تأكد من البيانات");

            var data = _context.Employees.Find(id);

            if (data == null)
                throw new ArgumentException("لاتوجد بيانات");
            var employeedata = new EmployeeModels
            {
                Id = data.Id,
                Birthdate = data.Birthdate,
                FullName = data.FullName,
            };


            return employeedata;


        }

        public void Update(int id, EmployeeModels employee)
        {
            if (employee == null) throw new ArgumentNullException("");

            if (id == 0) throw new ArgumentNullException("");

            var employeedata =
                _context.Employees.Find(id);



            employeedata.Birthdate = employee.Birthdate;
            employeedata.FullName = employee.FullName;

            _context.SaveChanges();
        }
    }
}
