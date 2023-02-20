using System;
using System.Collections;
using System.Data.Common;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CollectionsCS
{
    internal class Program
    {
        static Random _rd = new Random();
        static void Main(string[] args)
        {
            /*
             * 컬렉션은 같은 성격을 띄는 자료를 담는 자료 구조이다.
             * 배열도 알고보면 .net FrameWork가 제공하는 컬렉션 자료 구조의 일부이다.
             * ArrayList, Queue, Stack, HashTable
             * 기본 컬렉션들의 요소의 자료형은 모두 'object' 이다.
             */

            /*[ArrayList]
            배열과 가장 닮은 컬렉션이다.
            컬렉션 요소에 접근시 []연산자로 접근 가능하다.
            처음 할당할 시 크기를 지정할 필요 없이 자동으로 크기가 늘거나 준다.*/
            /*ArrayList lt = new ArrayList();
           Console.WriteLine("lt's count = {0}, lt's Capacity = {1}", lt.Count, lt.Capacity);
           lt.Add(10);
           lt.Add(30);
           lt.Add("xyz");
           lt.Add("asdf");

           Console.WriteLine("lt's count = {0}, lt's Capacity = {1}", lt.Count, lt.Capacity);
           for (int i = 0; i < lt.Count; i++)
           {
               Console.WriteLine("lt[{0}] = {1}", i, lt[i]);
           }

           lt.RemoveAt(1);
           Console.WriteLine("======[remove : index 1]==========");
           Console.WriteLine("lt's count = {0}, lt's Capacity = {1}", lt.Count, lt.Capacity);
           for (int i = 0; i < lt.Count; i++)
           {
               Console.WriteLine("lt[{0}] = {1}", i, lt[i]);
           }

           lt.Insert(1, 30);
           lt.Add(99);
           Console.WriteLine("======[remove : insert 1 && add ]==========");
           Console.WriteLine("lt's count = {0}, lt's Capacity = {1}", lt.Count, lt.Capacity);
           for (int i = 0; i < lt.Count; i++)
           {
               Console.WriteLine("lt[{0}] = {1}", i, lt[i]);
           }

           lt.RemoveAt(4);
           lt.RemoveAt(2);
           Console.WriteLine("======[remove : 2remove 4, 2 ]==========");
           Console.WriteLine("lt's count = {0}, lt's Capacity = {1}", lt.Count, lt.Capacity);
           for (int i = 0; i < lt.Count; i++)
           {
               Console.WriteLine("lt[{0}] = {1}", i, lt[i]);
           }

           lt.Add(3.14f);
           lt.Add("abc");
           lt.Add("hello");
           lt.Insert(3, "fire");
           Console.WriteLine("======[remove : insert 3 && 3add ]==========");
           Console.WriteLine("lt's count = {0}, lt's Capacity = {1}", lt.Count, lt.Capacity);
           for (int i = 0; i < lt.Count; i++)
           {
               Console.WriteLine("lt[{0}] = {1}", i, lt[i]);
           }
           int[] aaa = new int[10];
           Console.WriteLine(aaa.GetType());
           Console.WriteLine(aaa.GetType().BaseType);*/

            /*[Queue]
             * Queue 자료 구조는 자료를 순서대로 입력해뒀다가 입력한 순서대로 자료를 꺼내서 사용할 수 있도록 한다(FIFO).
             * Queue 자료 구조는 개념적으로 터널 구조라고 설명한다.
             * 다른 자료구조와 다른 점은 계속 저장하는 개념이 아니라 저장했다가 사용하면 사라지는 개념이다.
             */
            /*Queue testQ = new Queue();
            testQ.Enqueue(1);
            testQ.Enqueue(2);
            testQ.Enqueue("three");
            testQ.Enqueue("four");
            Console.WriteLine("testQ's count = {0}", testQ.Count);

            while(testQ.Count > 0) 
            {
                Console.WriteLine("testQ's dequeue : {0}", testQ.Dequeue());
            }
            Console.WriteLine("testQ's count = {0}", testQ.Count);*/
            /*Console.WriteLine("testQ's dequeue = {0}, testQ's count = {1}", testQ.Dequeue(), testQ.Count);
              Console.WriteLine("testQ's dequeue = {0}, testQ's count = {1}", testQ.Dequeue(), testQ.Count);
              Console.WriteLine("testQ's dequeue = {0}, testQ's count = {1}", testQ.Dequeue(), testQ.Count);
              Console.WriteLine("testQ's dequeue = {0}, testQ's count = {1}", testQ.Dequeue(), testQ.Count);*/

            /* [Stack]
             * Stack 자료 구조는 Queue 자료 구조 처럼 자료가 없어지는 형태이다.
             * Stack 자료 구조는 통 모양의 형태로 개념을 설명하며 먼저 저장된 자료가 나중에 꺼낼 수 있다(LIFO).
             */
            /*Stack sampleStack = new Stack();
            for(int i = 0; i < 5; i++)
            {
                object val = _rd.Next();
                sampleStack.Push(val);
                Console.WriteLine("Input value = {0}", val);
            }
            Console.WriteLine("sampleStack;s Count = {0}", sampleStack.Count);
            Console.WriteLine("=============================================");
            while (sampleStack.Count > 0)
            {
                Console.WriteLine("sampleStack's pop = {0}",sampleStack.Pop());
            }
            Console.WriteLine("sampleStack;s Count = {0}", sampleStack.Count);*/

            /* [HashTable]
             * Hash Table 자료 구조는 Key랑 value가 쌍으로 이루어진 node를 사용한다.
             * Hash Table 자료 구조는 Hash함수를 이용하여 저장과 삭제를 한다.
             * []연산자를 사용하여 저장과 찾기가 가능하다.
             */
            /*Hashtable sHash = new Hashtable();
            sHash.Add("book", "책");
            sHash["cooker"] = "요리";
            sHash["cooker"] = "요리사"; // 있으면 요리사로 편집됨
            sHash.Add(1, "First");
            
            //Console.WriteLine(sHash["book"]);
            //Console.WriteLine(sHash["cooker"]);
            //Console.WriteLine(sHash[1]);

            foreach(DictionaryEntry element in sHash)
            {
                Console.WriteLine("sHash[{0}] = {1}", element.Key, element.Value);
            }
            Console.WriteLine("============================");
            foreach(object element in sHash.Values)
            {
                Console.WriteLine("value = {0}",element);
            }
            Console.WriteLine("============================");
            foreach (object key in sHash.Keys)
            {
                Console.WriteLine("sHash[{0}] = {1}", key, sHash[key]);
            }*/



            /*
             * 1.생성
             * 2.삭제
             * 3.확인
             * 4.나가기
             * 번호를 선택하세요 :
             */
            Hashtable Item_Info = new Hashtable();
            Item item = new Item();
            while(true) 
            {
                Console.WriteLine("========[메뉴]=============");
                Console.WriteLine("1. 생성");
                Console.WriteLine("2. 삭제");
                Console.WriteLine("3. 확인");
                Console.WriteLine("4. 나가기");
                Console.WriteLine("============================");
                Console.Write("번호를 선택하세요 : ");
                
                int num_check;
                bool check = int.TryParse(Console.ReadLine(), out num_check);
                if(num_check == 4)
                {
                    break;
                }
                else
                {
                    ItemInfoMenu(item, num_check, Item_Info);
                }
                
                /*if (check)
                {
                    if (num_check == 1)
                    {
                        string NewName;
                        Item_Rank NewRank;
                        int NewPrice;
                        while (true)
                        {
                            Console.WriteLine("=====[아이템 생성]=================================");
                            Console.Write("아이템 이름을 작성하세요 : ");
                            NewName = Console.ReadLine();
                            bool NameCheck = Item_Info.Contains(NewName);
                            if (NameCheck)
                            {
                                Console.WriteLine("중복된 아이템 이름입니다.\n다시 입력해 주세요.\n");
                            }
                            else
                                break;
                        }
                        while (true)
                        {
                            Console.WriteLine("1.rubbish 2.normal 3.magic 4.rare 5.unique");
                            Console.Write("아이템 등급을 입력하세요 : ");
                            int Rank_num;
                            bool RankCheck = int.TryParse(Console.ReadLine(), out Rank_num);
                            if (RankCheck)
                            {
                                if (Rank_num >= 1 && Rank_num <= 4)
                                {
                                    NewRank = (Item_Rank)Rank_num;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("1 ~ 4의 숫자를 입력해 주세요.\n");
                                }
                            }
                            else
                                Console.WriteLine("숫자를 입력해 주세요.\n");
                        }
                        while (true)
                        {
                            Console.Write("가격을 입력하세요 : ");
                            int price_num;
                            bool PriceCheck = int.TryParse(Console.ReadLine(), out price_num);
                            if (PriceCheck)
                            {
                                if (price_num > 0)
                                {
                                    NewPrice = price_num;
                                    break;
                                }
                                else
                                    Console.WriteLine("0 이하의 숫자는 적으실 수 없습니다.\n");

                            }
                            else
                                Console.WriteLine("숫자를 입력해 주세요.\n");
                        }
                        Console.WriteLine("=====================================================");
                        Item_Info.Add(NewName, new Item(NewName, NewPrice, NewRank));
                        item = (Item)Item_Info[NewName];
                        item.Item_InfoTexture();
                    }
                    else if (num_check == 2)
                    {
                        Console.WriteLine("====[아이템 삭제]================================");
                        int count = 1;
                        foreach (object element in Item_Info.Keys)
                        {
                            if (count == Item_Info.Count)
                                Console.WriteLine(element.ToString());
                            else
                                Console.Write(element.ToString() + ", ");
                            count++;
                        }
                        Console.WriteLine("{0}개의 아이템이 있습니다.", Item_Info.Count);
                        while (true)
                        {
                            Console.Write("삭제할 아이템 이름을 입력하세요(나가기 Q/q) : ");
                            string delectName = Console.ReadLine();
                            if (delectName.Equals("q") || delectName.Equals("Q"))
                            {
                                Console.WriteLine("=====================================================================");
                                break;
                            }
                            else
                            {
                                bool Delect_check = Item_Info.Contains(delectName);
                                if (Delect_check)
                                {
                                    Item_Info.Remove(delectName);
                                    Console.WriteLine("{0} 아이템이 삭제되어 {1}개의 아이템이 남았습니다.", delectName, Item_Info.Count);
                                    Console.WriteLine("=====================================================================");
                                }
                                else
                                    Console.WriteLine("없는 이름입니다. 다시입력해 주세요.\n");
                            }
                            Console.WriteLine("=====================================================================");
                        }

                    }
                    else if (num_check == 3)
                    {
                        Console.WriteLine("====[아이템 확인]====================================");
                        Console.WriteLine("1. 전체 확인");
                        Console.WriteLine("2. 개별 확인");
                        Console.WriteLine("=========================================================");
                        Console.Write("번호를 선택하세요 : ");
                        int confirm_num;
                        bool confirm_check = int.TryParse(Console.ReadLine(), out confirm_num);
                        if (confirm_check)
                        {
                            if (confirm_num == 1 || confirm_num == 2)
                            {
                                if (confirm_num == 1)
                                {
                                    foreach (object element in Item_Info.Values)
                                    {
                                        item = (Item)element;
                                        item.Item_InfoTexture();
                                    }
                                }
                                else if(confirm_num == 2)
                                {
                                    int count = 1;
                                    foreach (object element in Item_Info.Keys)
                                    {
                                        if (count == Item_Info.Count)
                                            Console.WriteLine(element.ToString());
                                        else
                                            Console.Write(element.ToString() + ", ");
                                        count++;
                                    }
                                    Console.WriteLine("{0}개의 아이템이 있습니다.", Item_Info.Count);

                                    while (true)
                                    {
                                        Console.WriteLine("확인할 아이템의 이름을 입력하세요.(나가기 Q/q)");
                                        string confirm_name = Console.ReadLine();
                                        if (confirm_name.Equals("Q") || confirm_name.Equals("q"))
                                            break;
                                        else
                                        {
                                            bool dup_check = Item_Info.Contains(confirm_name);
                                            if (dup_check)
                                            {
                                                item = (Item)Item_Info[confirm_name];
                                                item.Item_InfoTexture();
                                            }
                                            else
                                                Console.WriteLine("없는 이름입니다. 다시 입력해주세요. \n");
                                        }
                                    }
                                }
                            }
                            else
                                Console.WriteLine("1 ~ 2 숫자를 입력해 주세요\n");
                        }
                        else
                            Console.WriteLine("숫자를 입력해 주세요\n");
                    }
                    else if (num_check == 4)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("1 ~ 4 숫자를 입력해 주세요.\n");
                    }
                }
                else
                {
                    Console.WriteLine("숫자를 입력해 주세요.\n");
                }*/
            }
            system("pause");
        }
        public static void ItemInfoMenu(Item item, int num_check, Hashtable Item_Info)
        {
            bool check = int.TryParse(Console.ReadLine(), out num_check);
            if (check)
            {
                if (num_check == 1)
                {
                    string NewName;
                    Item_Rank NewRank;
                    int NewPrice;
                    while (true)
                    {
                        Console.WriteLine("=====[아이템 생성]=================================");
                        Console.Write("아이템 이름을 작성하세요 : ");
                        NewName = Console.ReadLine();
                        bool NameCheck = Item_Info.Contains(NewName);
                        if (NameCheck)
                        {
                            Console.WriteLine("중복된 아이템 이름입니다.\n다시 입력해 주세요.\n");
                        }
                        else
                            break;
                    }
                    while (true)
                    {
                        Console.WriteLine("1.rubbish 2.normal 3.magic 4.rare 5.unique");
                        Console.Write("아이템 등급을 입력하세요 : ");
                        int Rank_num;
                        bool RankCheck = int.TryParse(Console.ReadLine(), out Rank_num);
                        if (RankCheck)
                        {
                            if (Rank_num >= 1 && Rank_num <= 4)
                            {
                                NewRank = (Item_Rank)Rank_num;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("1 ~ 4의 숫자를 입력해 주세요.\n");
                            }
                        }
                        else
                            Console.WriteLine("숫자를 입력해 주세요.\n");
                    }
                    while (true)
                    {
                        Console.Write("가격을 입력하세요 : ");
                        int price_num;
                        bool PriceCheck = int.TryParse(Console.ReadLine(), out price_num);
                        if (PriceCheck)
                        {
                            if (price_num > 0)
                            {
                                NewPrice = price_num;
                                break;
                            }
                            else
                                Console.WriteLine("0 이하의 숫자는 적으실 수 없습니다.\n");

                        }
                        else
                            Console.WriteLine("숫자를 입력해 주세요.\n");
                    }
                    Console.WriteLine("=====================================================");
                    Item_Info.Add(NewName, new Item(NewName, NewPrice, NewRank));
                    item = (Item)Item_Info[NewName];
                    item.Item_InfoTexture();
                }
                else if (num_check == 2)
                {
                    Console.WriteLine("====[아이템 삭제]================================");
                    int count = 1;
                    foreach (object element in Item_Info.Keys)
                    {
                        if (count == Item_Info.Count)
                            Console.WriteLine(element.ToString());
                        else
                            Console.Write(element.ToString() + ", ");
                        count++;
                    }
                    Console.WriteLine("{0}개의 아이템이 있습니다.", Item_Info.Count);
                    while (true)
                    {
                        Console.Write("삭제할 아이템 이름을 입력하세요(나가기 Q/q) : ");
                        string delectName = Console.ReadLine();
                        if (delectName.Equals("q") || delectName.Equals("Q"))
                        {
                            Console.WriteLine("=====================================================================");
                            break;
                        }
                        else
                        {
                            bool Delect_check = Item_Info.Contains(delectName);
                            if (Delect_check)
                            {
                                Item_Info.Remove(delectName);
                                Console.WriteLine("{0} 아이템이 삭제되어 {1}개의 아이템이 남았습니다.", delectName, Item_Info.Count);
                                Console.WriteLine("=====================================================================");
                            }
                            else
                                Console.WriteLine("없는 이름입니다. 다시입력해 주세요.\n");
                        }
                        Console.WriteLine("=====================================================================");
                    }

                }
                else if (num_check == 3)
                {
                    Console.WriteLine("====[아이템 확인]====================================");
                    Console.WriteLine("1. 전체 확인");
                    Console.WriteLine("2. 개별 확인");
                    Console.WriteLine("=========================================================");
                    Console.Write("번호를 선택하세요 : ");
                    int confirm_num;
                    bool confirm_check = int.TryParse(Console.ReadLine(), out confirm_num);
                    if (confirm_check)
                    {
                        if (confirm_num == 1 || confirm_num == 2)
                        {
                            if (confirm_num == 1)
                            {
                                foreach (object element in Item_Info.Values)
                                {
                                    item = (Item)element;
                                    item.Item_InfoTexture();
                                }
                            }
                            else if (confirm_num == 2)
                            {
                                int count = 1;
                                foreach (object element in Item_Info.Keys)
                                {
                                    if (count == Item_Info.Count)
                                        Console.WriteLine(element.ToString());
                                    else
                                        Console.Write(element.ToString() + ", ");
                                    count++;
                                }
                                Console.WriteLine("{0}개의 아이템이 있습니다.", Item_Info.Count);

                                while (true)
                                {
                                    Console.WriteLine("확인할 아이템의 이름을 입력하세요.(나가기 Q/q)");
                                    string confirm_name = Console.ReadLine();
                                    if (confirm_name.Equals("Q") || confirm_name.Equals("q"))
                                        break;
                                    else
                                    {
                                        bool dup_check = Item_Info.Contains(confirm_name);
                                        if (dup_check)
                                        {
                                            item = (Item)Item_Info[confirm_name];
                                            item.Item_InfoTexture();
                                        }
                                        else
                                            Console.WriteLine("없는 이름입니다. 다시 입력해주세요. \n");
                                    }
                                }
                            }
                        }
                        else
                            Console.WriteLine("1 ~ 2 숫자를 입력해 주세요\n");
                    }
                    else
                        Console.WriteLine("숫자를 입력해 주세요\n");
                }
                else
                {
                    Console.WriteLine("1 ~ 4 숫자를 입력해 주세요.\n");
                }
            }
            else
            {
                Console.WriteLine("숫자를 입력해 주세요.\n");
            }
        }
        public static int ReadInteger(string ask) { return int.Parse(ask); }
        public static float ReadFloat(string ask) { return float.Parse(ask); }
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
