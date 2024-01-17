using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubesh26._12._23
{
     class School  // IEnumerable
    {
        string Name;
        private readonly List<Student> Students = new List<Student>();
     //   private int currentIndex = -1;

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
            int studentIndex = 0;
            foreach (var student in Students)
            {
                studentIndex++;
                Console.WriteLine($"{studentIndex}. {student.FIO}, {student.grade}, {student.stage.Last()}");
               
            }
        }


        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}
       public void Sort()
        {
            Students.Sort();
        }
       
    }

    //public class EntranceEnumerator : IEnumerator
    //{
    //    private readonly Student[] students;
    //    private int currentIndex = -1;

    //    public object Current => throw new NotImplementedException();

    //    public bool MoveNext()
    //    {
    //        currentIndex++;
    //        if(currentIndex >= students.Length)
    //        {
    //            return false;
    //        }
    //        return true;
    //    }

    //    public void Reset()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

}
