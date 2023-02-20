using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsCS
{
    /*
     * 이름, 가격, 등급(rubbish, normal, magic, rare, unique)의 정보를 가지고 있고,
     * 가격은 매입가와 매출가가 10배 차이가 납니다. 가격 정보는 매입가 입니다.
     * 정보 출력은 이름, 등급, 매입가, 매출가의 순으로 출력이 되도록 합니다.
     */
    enum Item_Rank
    {
        rubbish = 1,
        normal,
        magic,
        rare,
        unique
    }

    class Item
    {
        string _name;
        int _price;
        Item_Rank _rank;

        public Item()
        {

        }
        public Item(string name, int price, Item_Rank rank)
        {
            _name = name;
            _price = price;
            _rank = rank;
        }

        public void Item_InfoTexture()
        {
            Console.WriteLine("=====[아이템 정보]======================");
            Console.WriteLine("이름 : {0}", _name);
            Console.WriteLine("등급 : {0}", _rank);
            Console.WriteLine("가격 : {0}", _price);
            Console.WriteLine("===========================================");
        }
    }
}
