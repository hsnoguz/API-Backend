using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DAL.Model
{
    public partial class QuestionVertical : IEntity
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string ColumnName { get; set; }
        public string Text { get; set; }
        public int Index { get; set; }
        public int ParentId { get; set; }
        public decimal Point { get; set; }
        public bool IsVisible { get; set; }
        [JsonIgnore]
        public virtual Question Question { get; set; }
    }
}
