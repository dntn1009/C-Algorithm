using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCS
{
    internal class Time : Student
    {
        int _sleep;
        int _goschool;
        int _lesson;
        int _lunch;
        int _lesson2;
        int _gohome;
        int _evening;
        int _study;

        public Time() { }
        public Time(string n, int a, eGender g, string sName, int grade, int sleep, int goschool, int lesson, int lunch, int lesson2, int gohome, int evening, int study) : base(n, a, g, sName, grade)
        {
            _sleep = sleep;
            _goschool = goschool;
            _lesson = lesson;
            _lunch = lunch;
            _lesson2 = lesson2;
            _gohome = gohome;
            _evening = evening;
            _study = study;
        }

        public void Timetexture(int number)
        {
            if (number >= 0 && number < _sleep)
            {
                DeepSleep();
            }
            else if (number >= _sleep && number < _goschool)
            {
                GoToSchool();
            }
            else if (number >= _goschool && number < _lesson)
            {
                SchoolLesson();
            }
            else if (number >= _lesson && number < _lunch)
            {
                Lunch();
            }
            else if (number >= _lunch && number < _lesson2)
            {
                SchoolLesson();
            }
            else if (number >= _lesson2 && number < _gohome)
            {
                GoHome();
            }
            else if (number >= _gohome && number < _evening)
            {
                EveningMeal();
            }
            else if (number >= _evening && number < _study)
            {
                Study();
            }
            else if (number >= _study && number <= 24)
            {
                DeepSleep();
            }
        }
    }
}
