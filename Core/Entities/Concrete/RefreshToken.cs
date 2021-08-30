using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
  public partial  class RefreshToken:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Token { get; set; }
        public bool IsUsing { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? InsertTime { get; set; }
    }
}
