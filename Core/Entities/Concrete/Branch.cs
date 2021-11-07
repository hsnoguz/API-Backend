using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{

    public partial class Branch : IEntity
    {

        public int Id { get; set; }
        public string Explanation { get; set; }
        public int? parentId { get; set; }
    }

}
