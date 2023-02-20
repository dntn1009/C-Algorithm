using System;
using System.Runtime.InteropServices.WindowsRuntime;
//using System.Threading;

namespace ClassCS
{
    // 클래스에 등급정보를 추가하여 등급이 3이하이면 쓰레기급, 3이상 9이하 저급, 14이상 이면 고급, 20 이상이면 최고급


    class Item
    {
        string _name;
        int _price;
        int _rank;
        string _quality;

        public int _duration
        {
            get;set;
        }
        public string _myName
        {
            get { return _name; }

        }
        public int _buyPrice
        {
            get { return _price; }
            set { _price = value; }
        }

        public int _salePrice
        {
            get { return _price / 10; }
        }

        public int _myRank
        {
            get { return _rank; }
            set
            {
                _rank = value;
                SettingQulityString();
            }
        }

        // 생성자는 클래스 이름으로 이름을 정하고 반환자는 없는 함수의 형태이다.
        // 생성자는 객체 생성시에 호출이 된다.
       /* public Item()
        {
            Console.WriteLine("기본 생성자가 호출되었습니다.");
            _name = "아이템";
            _price = 0;
            _rank = 1;
            _quality = string.Empty;
            _duration = 10;
        }*/

        public Item(string name, int price, int rank)
        {
            Console.WriteLine("초기화 생성자가 호출되었습니다.");
            _duration = 10;
            _name = name;
            _price = price;
            _rank = rank;
        }

        ~Item() 
        {
            Console.WriteLine("소멸자가 호출되었습니다.");
            //Thread.Sleep(6000);
        }
        void SettingQulityString()
        {
            if (_rank <= 3)
                _quality = "(쓰레기급)";
            else if (_rank > 3 && _rank <= 9)
                _quality = "(저급)";
            else if (_rank < 20 && _rank >= 14)
                _quality = "(고급)";
            else if (_rank >= 20)
                _quality = "(최고급)";
            else
                _quality = string.Empty;
        }
        public void useitem()
        {
            Console.WriteLine("{0}아이템을 사용하셨습니다.", _myName);
            Console.Write("내구도가 {0}에서", _duration);
            if (_duration > 0)
                _duration = _duration - 1;
            else if (_duration <= 0)
                _duration = 0;
            Console.WriteLine("{0}으로 떨어졌습니다.", _duration);
        }
        void SettingQulityWeapon()
        {

        }
        public void InitializeData(string name, int price, int rank)
        {
            _duration = 10;
            _name = name;
            _price = price;
            _rank = rank;
            SettingQulityString();
        }
        public void ShowInfo()
        {
            Console.WriteLine("━ [아이템 정보]━━━━━━━");
            Console.WriteLine("이름 : {0}", _name);
            Console.WriteLine("내구도 : {0}", _duration);
            Console.WriteLine("등급 : {0}{1}", _rank, _quality);
            Console.WriteLine("가격 : {0}", _price);
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━");
        }

        public string GetName()
        {
            return _name;
        }
        public int GetPrice()
        {
            return _price;
        }
        public void  SetRank(int rank)
        {
            _rank = rank;
            SettingQulityString();
        }
    }
}
