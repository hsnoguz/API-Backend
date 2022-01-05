using DAL.Model;
using Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Abstract
{
  public  interface IEfAimQuestionDal
    {
        public List<AimQuestion> getAimQuestionList(int projectId);
        public List<Question> getQuestionList(int aimId);
        public List<AimQuestion> getAimList(int projectId);
        public void addAim(AimQuestion question);
        public void editAim(AimQuestion question);
        public void deleteAim(int aimId);
    }
}
