using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace App.Project.Models
{
    public class EmployeeModels
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        //[DisplayName("الاسم")]
        public string FullName { get; set; }
        [DisplayName("تاريخ الميلاد")]
        public DateTime Birthdate { get; set; }
        public IEnumerable<EmployeeGridView> EmployeesGrid { get; set; }
    }
    public class EmployeeGridView
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime Birthdate { get; set; }
    }
}
