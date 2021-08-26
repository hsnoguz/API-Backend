using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
  public partial class Organization:IEntity
    {
        public int Id { get; set; }
        public string Explanation { get; set; }
        public Int16 parentId { get; set; }

    }
}
