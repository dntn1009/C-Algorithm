using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCS
{
    /*
     *  =======================================================================
     *                 Private           Protected           Private
     *  =======================================================================
     *  자식내            x                 o                   o
     *  =======================================================================
     *  외부              x                 x                   o
     *  =======================================================================
     *  
     *  =======================================================================
     */
    public enum eGender
    {
        남       =1,
        여,
    }
    //abstract
    class Person
    {
        string _name;
        int _age;
        eGender _gender;

        public string _MyName
        {
            get { return _name; }
        }
        public int _MyAge
        {
            get { return _age; }
        }
        public eGender _MyGender
        {
            get { return _gender; }
        }

        protected Person(string n, int a, eGender g)
        {
            _name = n;
            _age = a;
            _gender = g;
        }

        protected void InitBase(string n, int a, eGender g)
        {
            _name= n;
            _age = a;
            _gender = g;
        }

        //public abstract void PrintShow();
        public virtual void PrintShow()
        {
            Console.WriteLine("===[정보 창]==============");
            Console.WriteLine("이름 : {0}", _name);
            Console.WriteLine("성별 : {0}자", _gender);
            Console.WriteLine("나이 : {0}세", _age);
            Console.WriteLine("===============================");

        }

        public void DeepSleep()
        {
            Console.WriteLine("깊은 잠을 자고 있다.");
        }

        public void Breakfast()
        {
            Console.WriteLine("아침 식사를 하고 있다.");
        }
        
        public void Lunch()
        {
            Console.WriteLine("점심 식사를 하고 있다.");
        }
        public void EveningMeal()
        {
            Console.WriteLine("저녁 식사를 하고 있다.");
        }

    }
}
