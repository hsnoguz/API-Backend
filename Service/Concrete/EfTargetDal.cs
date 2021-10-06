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
    public class EfTargetDal : IEfTargetDal
    {
        private readonly IRepository<Target> _repository;
        public EfTargetDal(IRepository<Target> repository)
        {
            _repository = repository;
        }

        public void AddTarget(Target Target)
        {
            _repository.Insert(Target);
        }

        public List<Target> TargetListFull()
        {
            var TargetList = _repository.Table.ToList();
            return TargetList;
        }

        public List<Target> TargetList(int aimId)
        {
            var TargetList=_repository.Table.Where(x => x.AimId == aimId).ToList();
            return TargetList;
        }

        public void DeleteTarget( int id)
        {
            var Target = _repository.Table.Where(x => x.Id == id).FirstOrDefault();
            if (Target != null)
            {
                _repository.Delete(Target);
            }
            else
            {
                throw new Exception("Not Found Target");
            }



            
        }
    }
}
