using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubesh26._12._23
{
    class School : IEnumerable
    {
        string Name;
        private readonly List<Student> Students = new List<Student>();
        private int currentIndex = -1;

        public School(string name)
        {
            Name = name;
        }

        public void Add(Student _student)
        {
            Students.Add(_student);
        }


        public new void ToString()
        {
           
        }

       
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public class EntranceEnumerator : IEnumerator
    {
        private readonly Student[] students;
        private int currentIndex = -1;

        public EntranceEnumerator(Student[] _students)
        {
            this.students = _students;
        }


    }

}
