using DemoSlide4.Models;

namespace DemoSlide4.ModelView
{
    public class EmployessDepartment
    {
        public string nameEmp {  get; set; }
        public string std {  get; set; }
        public string DepName {  get; set; }
    }
   public class EmpAndDep
    {
        public void EmpAndDeps(EmployessDepartment empAndDep, Employess employess, Departments departments)
        {
            empAndDep.nameEmp = employess.NameEmp;
        }
    }
}
