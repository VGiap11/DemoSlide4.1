using DemoSlide4.Models;

namespace DemoSlide4.IResponsitory.Responsitory
{
    public class EmployessRespository : IEmployessRespository
    {
        private readonly AppDbContext _appDbContext;
        public EmployessRespository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void AddEmp(Employess employess)
        {
            try
            {
                _appDbContext.Employesses.Add(employess);
                _appDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool DeleteEmp(int id)
        {
            try
            {
                var idemp = _appDbContext.Employesses.FirstOrDefault(x => x.Id == id);
                if (idemp != null)
                {
                    _appDbContext.Employesses.Remove(idemp);
                    _appDbContext.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Employess Get(int id)
        {
            try
            {
               var findId= _appDbContext.Employesses.FirstOrDefault(x=>x.Id==id);
                if (findId != null)
                {
                    return findId;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Employess> GetallEmp()
        {
            try
            {
                var getall = _appDbContext.Employesses.ToList();
                if (getall != null)
                {
                    return getall;
                }
                else
                {
                    return null;
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool UpdateEmp(int id, Employess employess)
        {
            try
            {
                var findId= _appDbContext.Employesses.FirstOrDefault(x=>x.Id == id);
                if (findId != null)
                {
                    findId.NameEmp = employess.NameEmp;
                    findId.SDT = employess.SDT;
                    findId.Bithdate = employess.Bithdate;
                    _appDbContext.Employesses.Update(findId);
                    _appDbContext.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
