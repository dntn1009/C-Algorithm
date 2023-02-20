using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassCS
{
    class Student : Person
    {
        string _schoolName;
        int _grade;
        

        public Student() : base("사람", 0, eGender.남) // Initialize
        {
            _schoolName = "검정";
            _grade = 1;
        }

        public Student(string n, int a, eGender g, string sName, int grade) : base(n, a, g)
        {
            _schoolName = sName;
            _grade= grade;
        }

        public override void PrintShow()
        {
            //base.PrintShow();
            Console.WriteLine("===[학생 정보 창]==============");
            Console.WriteLine("이름 : {0}", _MyName);
            Console.WriteLine("성별 : {0}자", _MyGender);
            Console.WriteLine("나이 : {0}세", _MyAge);
            Console.WriteLine("학교 : {0}학교", _schoolName);
            Console.WriteLine("학년 : {0}학년", _grade);
            Console.WriteLine("===============================");
        }

        public void GoToSchool()
        {
            Console.WriteLine("{0}학교에 가고 있다.", _schoolName);
        }
        public void GoHome()
        {
            Console.WriteLine("집에 가고 있다.");
        }
        public void SchoolLesson()
        {
            Console.WriteLine("학교 수업을 하고 있다.");
        }
        public void Study()
        {
            Console.WriteLine("공부를 하고 있다.");
        }
        public void OutputStudentInfo()
        {
            Console.WriteLine("내 이름은 {0}, {1}세 {2}자 학생 입니다.", _MyName, _MyAge, _MyGender);
            Console.WriteLine("{0}학년이고, {1} 학교를 다니고 있습니다.", _grade, _schoolName);
        }

    }
}
