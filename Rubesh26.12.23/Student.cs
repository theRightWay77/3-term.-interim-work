using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubesh26._12._23
{
    class Student
    {
        static char[] alfavit = { 'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z' };
        static int letterTurn = 0;

        public string FIO;//имя
        public int grade; //класс
        public double performance; //средний балл
        public List<string> stage = new List<string>(); // список этапов

        public Student()//создает рандомного ученика
        {
            FIO = alfavit[letterTurn].ToString();
            Random rnd = new Random();
            grade = rnd.Next(1, 12);
            performance = rnd.Next(2, 5) + Math.Round(rnd.NextDouble(), 1);
            WhichStage(grade);

            letterTurn++;
            if (letterTurn == 27) letterTurn = 0;
        }

        private void WhichStage(int grade)
        {
            if (grade <= 4)
            {
                stage.Add("elementary");
            }
            else if (grade <= 8)
            {
                stage.Add("elementary");
                stage.Add("secondary");
            }
            else if (grade <= 11)
            {
                stage.Add("elementary");
                stage.Add("secondary");
                stage.Add("higher");
            }
        } //записывает этапы обучения в зависимости от возраста

        public Student(string _fio, int _grade, double _performance)
        {
            FIO = _fio;
            grade = _grade;
            performance = _performance;
            WhichStage(grade);
        }

        public void Pass() //увеливичает номер класса и меняет список этапов, при необходимости
        {
            grade++;
            WhichStage(grade);
        }

        public override string ToString()
        {
            string stageRU = string.Empty;
            if (stage.Last() == "elementary") stageRU = "младшая";
            else if (stage.Last() == "secondary") stageRU = "средняя";
            else if (stage.Last() == "higher") stageRU = "старшая";
            return $"{FIO}, {stageRU} школа, {grade} класс, {performance} балла";
        }
    }
}
