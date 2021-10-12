using DAL.Model;
using Repository;
using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Concrete
{
    public class EfAimDal : IEfAimDal
    {
        private readonly IRepository<Aim> _repository;
        public EfAimDal(IRepository<Aim> repository)
        {
            _repository = repository;
        }

        public void AddAim(Aim aim)
        {
            _repository.Insert(aim);
        }

        public List<Aim> AimList(int periotId)
        {
            var aimList=_repository.Table.Where(x => x.PeriotId == periotId).ToList();
            return aimList;
        }


        public void EditAim(int id,  string explanation)
        {
            var aim = _repository.Table.Where(x => x.Id == id).FirstOrDefault();

            if (aim != null)
            {
                aim.Explanation = explanation;
            }
            else
            {
                throw new Exception("Not Found SubAction");
            }
        }
        public void DeleteAim( int id)
        {
            var aim = _repository.Table.Where(x => x.Id == id).FirstOrDefault();
            if (aim != null)
            {
                _repository.Delete(aim);
            }
            else
            {
                throw new Exception("Not Found Aim");
            }



            
        }
    }
}
