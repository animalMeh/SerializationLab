using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journal.Controller
{
    class Controller
    {
        public static bool CorrectEnterance(string str)
        {
            if (string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str))
                return false;
            else return true;

        }

        public static bool IsTeacherExsist(string TeacherName , List<Model.Teacher> l)
        {
            if (l.Find(te => te.Name == TeacherName) == null)
                return false;
            else return true;
        }

        public static bool IsSubjectExsist(string SubjectName, List<Model.Subject> l)
        {
            if (l.Find(su => su.Name == SubjectName) == null)
                return false;
            else return true;
        }

        public static Model.Teacher AddTeacher(string TeacherName, List<Model.Teacher> l)
        {
            if (IsTeacherExsist(TeacherName, l))
                return l[l.FindIndex(te => te.Name == TeacherName)];
            else
            {
                Model.Teacher t;
                t = new Model.Teacher(TeacherName);
                l.Add(t);
                return t;
            }
        }

        public static Model.Teacher GetTeacher(string TeacherName, List<Model.Teacher> l)
        {
            if (IsTeacherExsist(TeacherName , l))
                return l[l.FindIndex(te => te.Name == TeacherName)];
            else return null;
        }

        public static Model.Subject AddSubject(string SubjectName, List<Model.Subject> l)
        {
            Model.Subject s;
          
            s = new Model.Subject(SubjectName);
            l.Add(s);
          
            return s;
        }

        public static Model.Subject GetSubject(string SubjectName, List<Model.Subject> l)
        {
            if (IsSubjectExsist(SubjectName , l))
                return l[l.FindIndex(su => su.Name == SubjectName)];
            else return null;
        }
    }
}
