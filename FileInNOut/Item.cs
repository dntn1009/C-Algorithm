using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileInNOut
{
    internal class Item
    {
        string _name;
        int _rank;
        int _price;

        public Item(string name, int rank, int price)
        {
            _name = name;
            _rank = rank;
            _price = price;
        }

        public void Confirm_Texture()
        {
            Console.WriteLine("====[확인 정보]==============");
            Console.WriteLine("이름 : {0}", _name);
            Console.WriteLine("랭크 : {0}", _rank);
            Console.WriteLine("가격 : {0}", _price);
            Console.WriteLine("=============================");
        }

        public void ItemTexture()
        {
            Console.WriteLine("====[수정 정보]==============");
            Console.WriteLine("1. 이름 : {0}", _name);
            Console.WriteLine("2. 랭크 : {0}", _rank);
            Console.WriteLine("3. 가격 : {0}", _price);
            Console.WriteLine("=============================");
        }

        public void ItemSave(StreamWriter sw)
        {
            sw.Write("{0} {1} {2}", _name, _rank, _price);
            sw.WriteLine();
        }

        public void Modi_name(string name) { _name = name; }
        public void Modi_rank(int rank) { _rank = rank; }
        public void Modi_price(int price) { _price = price; }
    }
}
