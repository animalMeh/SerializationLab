using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journal.Model
{
    [Serializable]
     public class Subject
    {
        public string Name { get; set; }
        public List<Teacher> TaughtBy;

        public Subject() { TaughtBy = new List<Teacher>(); }

        public Subject(string Name)
        {
            this.Name = Name;
            TaughtBy = new List<Teacher>();
        }

        public void AddTeacher(Teacher t)
        {
            if (TaughtBy.Contains(t))
                return;
            else
            {
                TaughtBy.Add(t);
            }
            t.AddSubject(this);
        }

        public void DropTeacher(Teacher t)
        {
            if (TaughtBy.Contains(t))
            {
                TaughtBy.Remove(t);
                t.DropSubject(this);
            }
        }
    }
}
