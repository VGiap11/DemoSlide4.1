using DemoSlide4.Models;

namespace DemoSlide4.Iservice
{
    public interface IserviceEmployess
    {
        public List<Employess> GetallEmp();
        public Employess Get(int id);
        public void AddEmp(Employess employess);
        public bool UpdateEmp(int id, Employess employess);
        public bool DeleteEmp(int id);
    }
}
