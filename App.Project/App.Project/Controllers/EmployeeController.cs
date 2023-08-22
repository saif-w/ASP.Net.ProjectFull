using App.Project.Infstracter;
using App.Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace App.Project.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeesServices _services;
        public EmployeeController(IEmployeesServices services)
        {
            _services=services;
        }
        public IActionResult Index()
        {
            try
            {
                var data=_services.GetEmployees();
                return View(data);
            }
            catch (Exception ex)
            {
                return View();
            }
            
        }
        [HttpPost]
        public IActionResult Index(int Id, IFormCollection form)
        {
            var Delete = form["Delete"];

            if (Delete == "")
            {
                return RedirectToAction("Index");
            }
            else
            {

                DeleteEmployee(Id);
                return RedirectToAction("Index");
            }
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var data = _services.GetEmployees(id);

            return View(data);
        }
        [HttpPost]
        public IActionResult Details(int id, EmployeeModels model)
        {
            Update(id,model);

            return RedirectToAction("Index");
        }
        public IActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Create(EmployeeModels model)
        {
            try
            {
                if (model.FullName == null)
                {
                    ModelState.AddModelError("fullname", "الرجاء ادخال الاسم");
                    return View();
                }
                if(model.Birthdate.Date == Convert.ToDateTime("01/01/0001"))
                {
                    ModelState.AddModelError("Birthdate", "الرجاء ادخال تاريخ الميلاد");
                    return View();
                }
                
                    _services.Add(model);
                    TempData["Done"] = "تمت الاضافة بانجاح";
                    return RedirectToAction("Index");

                
                
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["Erorr"] = "يوجد خطاء في الادخال";
                return View(model);
            }
        }

        
        public void DeleteEmployee(int Id)
        {

            try
            {
                _services.Delete(Id);
                TempData["Done"] = "تم الحذف با نجاح";
            }
            catch (Exception ex)
            {

                TempData["Erorr"]=ex.Message;
            }

        }

        [HttpPost]
        public void Update(int Id,EmployeeModels model)
        {
            try
            {

                _services.Update(Id,model);
                TempData["Done"] = "تم التعديل بانجاح";
              
            }
            catch (Exception ex)
            {

                TempData["Error"] = ex.Message;
            }
        }
      
    }
}
