using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubesh26._12._23
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student a = new Student();
            //Console.WriteLine(   a.ToString());

            //Student bb = new Student();
            //Console.WriteLine(bb.ToString());

            //Student cc = new Student();
            //Console.WriteLine(cc.ToString());

            Student studA = new Student();
            Student studB = new Student();
            Student studBagaev = new Student("Багаев Аслан", 4, 4);
            Student studAbaev = new Student("Абаев Георгий", 4, 3.4);
            Student studAtaev = new Student("Атаев Сослан", 4, 3);

            School school = new School("ФизМат");
            school.Add(studB);
            school.Add(studBagaev);
            school.Add(studAbaev);
            school.Add(studA);
            school.Add(studAtaev);
            Console.WriteLine(school);

            school.Sort();

            Console.WriteLine(school);

        }
    }
}
