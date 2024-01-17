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

            Student studA = new Student("Ю Аслан", 11, 4);
            Student studB = new Student("Я Аслан", 1, 4);
            Student studBagaev = new Student("Багаев Аслан", 4, 4);
            Student studAbaev = new Student("Абаев Георгий", 9, 3.4);
            Student studAtaev = new Student("Атаев Сослан", 4, 3);
            Student studAtaev2 = new Student("Атаев Сослан", 1, 3);

            School school = new School("ФизМат");
            school.Add(studB);
            school.Add(studBagaev);
            school.Add(studAbaev);
            school.Add(studAtaev2);
            school.Add(studA);
            school.Add(studAtaev);
            school.ToString();
                
            school.Sort();

            Console.WriteLine();
            school.ToString();
            //  Console.WriteLine(school);

        }
    }
}
