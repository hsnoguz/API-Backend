using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Model
{
   public class EditProjectIndexDto:ICustomEntity
    {
        public int QuestionId { get; set; }
        public int QuestionIndex { get; set; }

    }
}
