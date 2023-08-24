using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
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
        public byte[] ImageData { get; set; }             
        public IEnumerable<EmployeeGridView> EmployeesGrid { get; set; }
    }
    public class EmployeeGridView
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime Birthdate { get; set; }
        public byte[] ImageData { get; set; }
    }
}
