﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journal.Model
{
    [Serializable]
    public class Teacher
    {
        public string Name { get; set; }
        public List<Subject> Teaching = new List<Subject>();

        public Teacher()
        { }

        public Teacher(string Name)
        {
            this.Name = Name;
        }
       
        public void AddSubject(Subject s)
        {
            if (Teaching.Contains(s))
                return;
            else
            {
                Teaching.Add(s);
            }
            s.AddTeacher(this);
        }

        public void DropSubject(Subject s)
        {
            if (Teaching.Contains(s))
            {
                Teaching.Remove(s);
                s.DropTeacher(this);
            }
        }
    }
}
