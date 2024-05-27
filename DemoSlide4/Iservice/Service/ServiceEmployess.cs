using DemoSlide4.IResponsitory;
using DemoSlide4.Models;

namespace DemoSlide4.Iservice.Service
{
    public class ServiceEmployess : IserviceEmployess
    {
        public readonly IEmployessRespository _empRespository;
        public ServiceEmployess(IEmployessRespository employessRespository)
        {
            _empRespository = employessRespository;
        }
        public void AddEmp(Employess employess)
        {
            _empRespository.AddEmp(employess);
        }

        public bool DeleteEmp(int id)
        {
            var check = _empRespository.DeleteEmp(id);
            return check;
        }

        public Employess Get(int id)
        {
           var Emp =  _empRespository.Get(id);
            return Emp;
        }

        public List<Employess> GetallEmp()
        {
            var ltsEmp = _empRespository.GetallEmp();
            return ltsEmp;
        }

        public bool UpdateEmp(int id, Employess employess)
        {
            var checkUpdate = _empRespository.UpdateEmp(id, employess);
            return checkUpdate;
        }
    }
}
