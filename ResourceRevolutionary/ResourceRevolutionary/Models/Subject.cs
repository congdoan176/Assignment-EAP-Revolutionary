using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResourceRevolutionary.Models
{
    public class Subject
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public SubjectStatus Status { get; set; }

        public Subject()
        {
            this.CreateAt = DateTime.Now;
            this.UpdateAt = DateTime.Now;
            this.Status = SubjectStatus.Active;
        }
    }
    public enum SubjectStatus
    {
        Active = 1,
        Deactive = 0
    }
}
