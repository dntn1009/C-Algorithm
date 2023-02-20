using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;

namespace FileInNOut
{
    struct Scores
    {
        public int _kor;
        public int _eng;
        public int _math;
        public float _aver;
        public int _rank;

        public Scores(int k, int e, int m)
        {
            _kor = k;
            _eng = e;
            _math = m;
            _aver = (_kor + _eng + _math) / 3;
            _rank = 0;
        }
    }
    


    class Program
    {
        static void Main(string[] args)
        {
            /* FiledeMode Type별 설명
             * CreateNew = 파일을 만든다. 단, 같은 파일이 있으면 예외 발생.
             * Create = 파일을 만든다. 단, 같은 파일이 있으면 덮어쓴다.
             * Open = 기존의 파일을 연다 단, 파일이 없으면 예외 발생.
             * OpenOrCreate = 기존의 파일을 연다 단, 파일이 없으면 파일을 만든다.
             * Truncate = 기존의 파일을 연다. 단, 해당 파일이 열리면 0byte가 된다.
             * Append = 기존의 파일을 열되 파일의 끝까지 검색한다. 단, 파일이 없다면 파일을 만든다.
             */

            /*텍스트 파일에 대한 Write & Read
             * 파일에 쓰기
                FileStream fs = new FileStream("Sample.txt", FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(32);
                sw.WriteLine("안녕하세요~~");
                sw.WriteLine(3.14);
                sw.Close();
             * 파일에 읽기
                FileStream fs = new FileStream("Sample.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                while(sr.EndOfStream == false)
                {
                    Console.WriteLine(sr.ReadLine());
                }
             */
            /* 바이너리 파일에 대한 Write & Read
             * 
             *
            FileStream fs = new FileStream("Test.bin", FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(32);
            bw.Write("안녕하세요~~");
            bw.Write(3.14);
            bw.Close();
            */

            /*FileStream fs = new FileStream("Test.bin", FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            while (br.PeekChar() >= 0)
            {
                Console.WriteLine(br.ReadInt32());
                Console.WriteLine(br.ReadString());
                Console.WriteLine(br.Readdouble());
            }
            br.Close();*/

            /* 객체 직렬화를 사용하며 파일에 Write & Read
             * 
             */
            /*StudentInfo info = new StudentInfo();
            info.InitDataSet("홍길동", 19, 181.2f, 77.4f);
            Stream stream = new FileStream("Info.dat", FileMode.Create);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(stream, info);
            stream.Close();

            Stream stream = new FileStream("Info.dat", FileMode.Open);
            BinaryFormatter deserizlizer = new BinaryFormatter();
            StudentInfo info = (StudentInfo)deserizlizer.Deserialize(stream);
            stream.Close();
            info.PrintShow();
            */

            /*
             * 몇개의 아이템을 입력하겠습니까?
             * 1번쨰 아이템 이름 :
             * 1번째 아이템 랭크(1~25) :
             * 1번째 아이템 가격 : 
             * 파일에 저장되었습니다.
             */
            /*Item item = null;
            Dictionary<string, Item> items = new Dictionary<string, Item>();
            try
            {
                FileStream fs2 = new FileStream("ItemTable.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs2);

                while (sr.EndOfStream == false)
                {
                    string[] str = sr.ReadLine().Split(' ');
                    items.Add(str[0], new Item(str[0], int.Parse(str[1]), int.Parse(str[2])));
                }
                sr.Close();
                fs2.Close();

            }
            catch (FileNotFoundException ex)
            {
            }
            FileStream fs = new FileStream("ItemTable.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            if (items != null)
            {
                foreach (Item element in items.Values)
                {
                    item = element;
                    item.ItemSave(sw);
                }
            }
            Hashtable Item_info = new Hashtable();
            while (true)
            {
                Console.Write("몇개의 아이템을 입력하시겠습니까? : ");
                int number;
                bool number_check = int.TryParse(Console.ReadLine(), out number);
                if (number_check && number != 0)
                {
                    for (int i = 0; i < number; i++)
                    {
                        string iname = null;
                        while (true)
                        {
                            Console.Write("{0}번째 아이템 이름 : ", i + 1);
                            iname = Console.ReadLine();
                            if (i == 0)
                            {
                                Item_info.Add(iname, true);
                                break;
                            }
                            else
                            {
                                bool check;
                                if (item == null)
                                    check = Item_info.Contains(iname);
                                else
                                    check = items.ContainsKey(iname);

                                if (check)
                                {
                                    Console.WriteLine("중복된 이름입니다. 다시 입력 해주세요.");
                                }
                                else
                                {
                                    Item_info.Add(iname, true);
                                    break;
                                }
                            }
                        }
                        Console.Write("{0}번째 아이템 랭크(1~25) : ", i + 1);
                        int irank = int.Parse(Console.ReadLine());
                        Console.Write("{0}번째 가격 : ", i + 1);
                        int iprice = int.Parse(Console.ReadLine());
                        sw.Write("{0} {1} {2}", iname, irank, iprice);
                        sw.WriteLine();
                    }

                }
                else
                    Console.WriteLine("0이 아닌 숫자를 입력해 주세요");
                sw.Close();
                Console.Write("모두 저장되었습니다.");
                break;
            }*/
            /* FileStream fs = new FileStream("ItemTable.txt", FileMode.Create);
             StreamWriter sw = new StreamWriter(fs);
             Hashtable Item_info = new Hashtable();
             while (true)
             {
                 Console.Write("몇개의 아이템을 입력하시겠습니까? : ");
                 int number;
                 bool number_check = int.TryParse(Console.ReadLine(), out number);
                 if (number_check && number != 0)
                 {
                     for (int i = 0; i < number; i++)
                     {
                         string iname = null;
                         while (true)
                         {
                             Console.Write("{0}번째 아이템 이름 : ", i + 1);
                             iname = Console.ReadLine();
                             if (i == 0)
                             {
                                 Item_info.Add(iname, true);
                                 break;
                             }
                             else
                             {
                                 bool check = Item_info.Contains(iname);
                                 if (check)
                                 {
                                     Console.WriteLine("중복된 이름입니다. 다시 입력 해주세요.");
                                 }
                                 else
                                 {
                                     Item_info.Add(iname, true);
                                     break;
                                 }
                             }
                         }
                         Console.Write("{0}번째 아이템 랭크(1~25) : ", i + 1);
                         int irank = int.Parse(Console.ReadLine());
                         Console.Write("{0}번째 가격 : ", i + 1);
                         int iprice = int.Parse(Console.ReadLine());
                         sw.Write("{0} {1} {2}", iname, irank, iprice);
                         sw.WriteLine();
                     }

                 }
                 else
                     Console.WriteLine("0이 아닌 숫자를 입력해 주세요");
                 sw.Close();
                 Console.Write("모두 저장되었습니다.");
                 break;
             }*/
            /* Item item;
             Dictionary<string, Item> items = new Dictionary<string, Item>();
             FileStream fs2 = new FileStream("ItemTable.txt", FileMode.Open);
             StreamReader sr = new StreamReader(fs2);
             while (sr.EndOfStream == false)
             {
                 string[] str = sr.ReadLine().Split(' ');
                 items.Add(str[0], new Item(str[0], int.Parse(str[1]), int.Parse(str[2])));
             }
             sr.Close();
             fs2.Close();
             foreach (string element in items.Keys)
             {
                 Console.WriteLine("items.Key = {0}" , element);
             }
             foreach (Item element in items.Values)
             {
                 element.ItemTexture();
             }*/

            //아이템 이름 가격
            /*Item item = null;
            Dictionary<string, Item> items = new Dictionary<string, Item>();
            OutputSaveFile(items);*/
            /*if (items != null)
            {
                foreach (Item element in items.Values)
                {
                    item = element;
                    item.ItemSave(sw);
                    item.ItemTexture();
                }
            }*/

            /*while (true)
            {

                int Choice = 0;
                bool check = MainMenuTexture(ref Choice);
                bool break_check = false;
                if (check)
                {
                    if (Choice > 0 && Choice < 6)
                    {
                        switch (Choice)
                        {
                            case 1:
                                Make_One(items);
                                break;
                            case 2:
                                Del_Two(items);
                                break;
                            case 3:
                                Modi_Three(items);
                                break;
                            case 4:
                                Confirm_Four(items);
                                break;
                            case 5:
                                break_check = true;
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("1 ~ 5 의 숫자를 입력해 주세요.");
                    }
                }
                else
                {
                    Console.WriteLine("숫자를 입력해 주세요. \n");
                }
                if (break_check)
                {
                    FileStream fs = new FileStream("ItemTable.txt", FileMode.Create);
                    StreamWriter sw = new StreamWriter(fs);
                    foreach (Item element in items.Values)
                    {
                        item = element;
                        item.ItemSave(sw);
                    }
                    sw.Close();
                    break;
                }
            }*/

            /*FileStream fs = new FileStream("info.bin", FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            while (true)
            {
                Console.Write("몇명 : ");
                int num = int.Parse(Console.ReadLine());
                for (int i = 0; i < num; i++)
                {
                    Console.Write("이름 : ");
                    string name = Console.ReadLine();
                    Console.Write("나이 : ");
                    int age = int.Parse(Console.ReadLine());
                    Console.Write("키 : ");
                    double cm = int.Parse(Console.ReadLine());
                    Console.Write("몸무게 : ");
                    double kg = int.Parse(Console.ReadLine());
                    bw.Write(name);
                    bw.Write(age);
                    bw.Write(cm);
                    bw.Write(kg);
                }
                break;
            }
            bw.Close();
            Console.WriteLine("저장완료");*/

            /* FileStream fs = new FileStream("info.bin", FileMode.Open);
             BinaryReader br = new BinaryReader(fs);
             List<StudentInfo> lt = new List<StudentInfo>();

             while (br.PeekChar() >= 0)
             {
                 StudentInfo std = new StudentInfo();
                 std.InitDataSet(br.ReadString(), br.ReadInt32(), br.ReadDouble(), br.ReadDouble());
                 lt.Add(std);
             }
             for (int i = 0; i < lt.Count; i++)
                 lt[i].PrintShow();*/

            /*Scores score = new Scores(55, 75, 89);
            Console.WriteLine("국어 점수 : {0}", score._kor);
            //Console.WriteLine("석차 : {0}", score._rank);*/

            UValue val1 = new UValue(10);

            Console.WriteLine("val + 6 = {0}", val1 + 6);
            Console.WriteLine("6 + val = {0}", 6 + val1);
            val1 = new UValue(val1 + 12);
            system("pause");
        }

        static void OutputSaveFile(Dictionary<string, Item> items)
        {
            try
            {
                FileStream fs2 = new FileStream("ItemTable.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs2);

                while (sr.EndOfStream == false)
                {
                    string[] str = sr.ReadLine().Split(' ');
                    items.Add(str[0], new Item(str[0], int.Parse(str[1]), int.Parse(str[2])));
                }
                sr.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        } // Try ~ Catch
        static bool MainMenuTexture(ref int Choice)
        {
            Console.WriteLine("====[메인 메뉴]==============");
            Console.WriteLine("1. 추가");
            Console.WriteLine("2. 삭제");
            Console.WriteLine("3. 수정");
            Console.WriteLine("4. 확인");
            Console.WriteLine("5. 나가기");
            Console.WriteLine("=============================");
            Console.Write("번호를 선택 하세요(1~5) : ");

            return int.TryParse(Console.ReadLine(), out Choice);
        }// MainMenu
        static void Make_One(Dictionary<string, Item> items)
        {
            Console.Write("몇개의 아이템을 입력하시겠습니까? : ");
            int item_num;
            bool item_num_check = int.TryParse(Console.ReadLine(), out item_num);
            if (item_num_check)
            {
                if (item_num > 0)
                {
                    for (int i = 0; i < item_num; i++)
                    {
                        string iname = null;
                        while (true)
                        {
                            Console.Write("{0}번째 아이템 이름 : ", i + 1);
                            iname = Console.ReadLine();
                            bool iname_check = items.ContainsKey(iname);
                            if (iname_check)
                            {
                                Console.WriteLine("중복된 이름입니다. 다시 입력 해주세요.");
                            }
                            else
                            {
                                break;
                            }
                        }
                        Console.Write("{0}번째 아이템 랭크(1~25) : ", i + 1);
                        int irank = int.Parse(Console.ReadLine());
                        Console.Write("{0}번째 가격 : ", i + 1);
                        int iprice = int.Parse(Console.ReadLine());
                        items.Add(iname, new Item(iname, irank, iprice));
                    }
                }
                else
                    Console.WriteLine("잘못된 입력입니다. 다시 입력해주세요.\n");
            }
            else
                Console.WriteLine("숫자를 입력해 주세요.\n");
        }// 1
        static void Del_Two(Dictionary<string, Item> items)
        {
            while (true)
            {
                Item Ditem;
                int i = 1;
                Hashtable Del_Info = new Hashtable();
                Console.WriteLine("====[삭제 메뉴]==============");
                foreach (string element in items.Keys)
                {
                    Console.WriteLine("{0}. {1}", i, element);
                    Del_Info.Add(i, element);
                    i++;
                }
                Console.WriteLine("=============================");
                Console.Write("삭제할 아이템을 선택하세요(0 = 나가기) : ");
                int del_choice = int.Parse(Console.ReadLine());
                if(del_choice > 0)
                {
                    items.Remove(Del_Info[del_choice].ToString());
                }
                else if (del_choice == 0)
                    break;
            }
        }// 2
        static void Modi_Three(Dictionary<string, Item> items)
        {
            while (true)
            {
                Item Mitem;
                int i = 1;
                Hashtable Modi_Info = new Hashtable();
                Console.WriteLine("====[수정 메뉴]==============");
                foreach (string element in items.Keys)
                {
                    Console.WriteLine("{0}. {1}", i, element);
                    Modi_Info.Add(i, element);
                    i++;
                }
                Console.WriteLine("=============================");
                Console.Write("수정할 아이템을 선택하세요(0 = 나가기) : ");
                int Modi_choice = int.Parse(Console.ReadLine());
                if(Modi_choice > 0)
                {
                    items.TryGetValue(Modi_Info[Modi_choice].ToString(), out Mitem);
                    Mitem.ItemTexture();
                    Console.Write("수정할 항목을 입력하세요 : ");
                    int Modify_num = int.Parse(Console.ReadLine());
                    switch(Modify_num)
                    {
                        case 1:
                            Console.Write("수정할 이름을 적어주세요 : ");
                            string Mname = Console.ReadLine();
                            Mitem.Modi_name(Mname);
                            items[Modi_Info[Modi_choice].ToString()] = Mitem;
                            break;
                        case 2:
                            Console.Write("수정할 등급을 적어주세요(1 ~ 25) : ");
                            int Mrank = int.Parse(Console.ReadLine());
                            Mitem.Modi_rank(Mrank);
                            items[Modi_Info[Modi_choice].ToString()] = Mitem;

                            break;
                        case 3:
                            Console.Write("수정할 가격을 적어주세요 : ");
                            int Mprice = int.Parse(Console.ReadLine());
                            Mitem.Modi_price(Mprice);
                            items[Modi_Info[Modi_choice].ToString()] = Mitem;
                            break;
                    }
                }
                else if (Modi_choice == 0)
                    break;
            }
        }// 3

        static void Confirm_Four(Dictionary<string, Item> items)
        {
            while (true)
            {
                Item Citem;
                int i = 1;
                Hashtable Conf_Info = new Hashtable();
                Console.WriteLine("====[확인 메뉴]==============");
                foreach (string element in items.Keys)
                {
                    Console.WriteLine("{0}. {1}", i, element);
                    Conf_Info.Add(i, element);
                    i++;
                }
                Console.WriteLine("=============================");
                Console.Write("확인할 아이템을 선택하세요(0 = 나가기) : ");
                int Modi_choice = int.Parse(Console.ReadLine());
                if (Modi_choice > 0)
                {
                    items.TryGetValue(Conf_Info[Modi_choice].ToString(), out Citem);
                    Citem.Confirm_Texture();
                }
                else if (Modi_choice == 0)
                    break;
            }
        }// 4
        
       
        
        static void system(string command)
        {
            if (command.CompareTo("pause") == 0)
            {
                Console.Write("계속하시려면 아무키나 누르세요...");
                Console.ReadKey();
            }
        }

    }
}
