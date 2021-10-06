using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DAL.Model
{
  public partial class Question:IEntity
    {

        public int Id { get; set; }

        public int ProjectId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Text { get; set; }
        public int Index { get; set; }
        public int ParentId { get; set; }

   
        public List<QuestionHorizontal> QuestionHorizontals { get; set; }
   
        public List<QuestionVertical> QuestionVerticals { get; set; }
        [JsonIgnore]
        public virtual Project Project { get; set; }
    }
}
