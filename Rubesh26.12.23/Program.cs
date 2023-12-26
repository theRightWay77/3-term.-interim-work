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
            Student studAbaev = new Student("Абаев Георгий", 7, 3.4);
            Student studBagaev = new Student("Багаев Аслан", 4, 4);
            Console.WriteLine(studA);
            Console.WriteLine(studB);
            Console.WriteLine(studAbaev);
            Console.WriteLine(studBagaev);
            studBagaev.Pass();
            Console.WriteLine(studBagaev);

        }
    }
}
