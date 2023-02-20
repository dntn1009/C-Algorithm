using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*CIArrayList aList = new CIArrayList();

                Console.WriteLine("aList's Capacity = {0}, aList's Count = {1}", aList._capacity, aList._count);
                aList.Add(1231);
                aList.Add(57);
                aList.Add("abc");
                Console.WriteLine("=================================================================");
                Console.WriteLine("aList's Capacity = {0}, aList's Count = {1}", aList._capacity, aList._count);
                for(int i = 0; i < aList._count; i ++)
                {
                    Console.WriteLine("aList[{0}] = {1}", i, aList[i]);
                }
                Console.WriteLine("=================================================================");
                aList.Add("Hello");
                aList.Add("꺼져");
                aList.Add(9.321);
                Console.WriteLine("aList's Capacity = {0}, aList's Count = {1}", aList._capacity, aList._count);
                for (int i = 0; i < aList._count; i++)
                {
                    Console.WriteLine("aList[{0}] = {1}", i, aList[i]);
                }
                Console.WriteLine("=================================================================");
                bool remove_cehck = aList.Remove(10);
                Console.WriteLine("<< index 10을 삭제 >>");
                if (!remove_cehck)
                    Console.WriteLine("없는 인덱스 입니다.");
                Console.WriteLine("aList's Capacity = {0}, aList's Count = {1}", aList._capacity, aList._count);
                for (int i = 0; i < aList._count; i++)
                {
                    Console.WriteLine("aList[{0}] = {1}", i, aList[i]);
                }
                Console.WriteLine("=================================================================");
                bool remove_cehck2 = aList.Remove(2);
                Console.WriteLine("<< index 2를 삭제 >>");
                if (!remove_cehck2)
                    Console.WriteLine("없는 인덱스 입니다.");
                Console.WriteLine("aList's Capacity = {0}, aList's Count = {1}", aList._capacity, aList._count);
                for (int i = 0; i < aList._count; i++)
                {
                    Console.WriteLine("aList[{0}] = {1}", i, aList[i]);
                }
                Console.WriteLine("=================================================================");
                bool insert_cehck = aList.Insert(3, 12343);
                Console.WriteLine("<< index 3에 값 삽입 >>");
                if (!insert_cehck)
                    Console.WriteLine("없는 인덱스 입니다.");
                Console.WriteLine("aList's Capacity = {0}, aList's Count = {1}", aList._capacity, aList._count);
                for (int i = 0; i < aList._count; i++)
                {
                    Console.WriteLine("aList[{0}] = {1}", i, aList[i]);
                }
                Console.WriteLine("=================================================================");
                bool insert_cehck2 = aList.Insert(15, 231321);
                Console.WriteLine("<< index 15에 값 삽입 >>");
                if (!insert_cehck2)
                    Console.WriteLine("없는 인덱스 입니다.");
                Console.WriteLine("aList's Capacity = {0}, aList's Count = {1}", aList._capacity, aList._count);
                for (int i = 0; i < aList._count; i++)
                {
                    Console.WriteLine("aList[{0}] = {1}", i, aList[i]);
                }
                Console.WriteLine("=================================================================");
                aList.sort();
                for (int i = 0; i < aList._count; i++)
                {
                    Console.WriteLine("aList[{0}] = {1}", i, aList[i]);
                }
                Console.WriteLine("=================================================================");
                aList.Reverse();
                for (int i = 0; i < aList._count; i++)
                {
                    Console.WriteLine("aList[{0}] = {1}", i, aList[i]);
                }*/

            /*   CIList<int> bList = new CIList<int>();
                Console.WriteLine("bList's Capacity = {0}, bList's Count = {1}", bList._capacity, bList._count);
                bList.Add(1);
                bList.Add(40);
                bList.Add(650);
                bList.Add(800);
                Console.WriteLine("=================================================================");
                Console.WriteLine("bList's Capacity = {0}, bList's Count = {1}", bList._capacity, bList._count);
                for (int i = 0; i < bList._count; i++)
                {
                    Console.WriteLine("bList[{0}] = {1}", i, bList[i]);
                }
                Console.WriteLine("=================================================================");
                bList.Add(650);
                bList.Add(800);
                Console.WriteLine("bList's Capacity = {0}, bList's Count = {1}", bList._capacity, bList._count);
                for (int i = 0; i < bList._count; i++)
                {
                    Console.WriteLine("bList[{0}] = {1}", i, bList[i]);
                }
                Console.WriteLine("=================================================================");
                bool remove_cehck = bList.Remove(10);
                Console.WriteLine("<< index 10을 삭제 >>");
                if (!remove_cehck)
                    Console.WriteLine("없는 인덱스 입니다.");
                Console.WriteLine("bList's Capacity = {0}, bList's Count = {1}", bList._capacity, bList._count);
                for (int i = 0; i < bList._count; i++)
                {
                    Console.WriteLine("bList[{0}] = {1}", i, bList[i]);
                }
                Console.WriteLine("=================================================================");
                bool remove_cehck2 = bList.Remove(2);
                Console.WriteLine("<< index 2를 삭제 >>");
                if (!remove_cehck2)
                    Console.WriteLine("없는 인덱스 입니다.");
                Console.WriteLine("bList's Capacity = {0}, bList's Count = {1}", bList._capacity, bList._count);
                for (int i = 0; i < bList._count; i++)
                {
                    Console.WriteLine("bList[{0}] = {1}", i, bList[i]);
                }
                Console.WriteLine("=================================================================");
                bool insert_cehck = bList.Insert(3, 12343);
                Console.WriteLine("<< index 3에 값 삽입 >>");
                if (!insert_cehck)
                    Console.WriteLine("없는 인덱스 입니다.");
                Console.WriteLine("bList's Capacity = {0}, bList's Count = {1}", bList._capacity, bList._count);
                for (int i = 0; i < bList._count; i++)
                {
                    Console.WriteLine("bList[{0}] = {1}", i, bList[i]);
                }
                Console.WriteLine("=================================================================");
                bool insert_cehck2 = bList.Insert(15, 231321);
                Console.WriteLine("<< index 15에 값 삽입 >>");
                if (!insert_cehck2)
                    Console.WriteLine("없는 인덱스 입니다.");
                Console.WriteLine("bList's Capacity = {0}, bList's Count = {1}", bList._capacity, bList._count);
                for (int i = 0; i < bList._count; i++)
                {
                    Console.WriteLine("bList[{0}] = {1}", i, bList[i]);
                }*/

            /*CILinkedList list = new CILinkedList();
                list.Add(234);
                list.Add(456);
                list.Add(789);
                list.Add("A");
                list.Add(787878);
                list.Add(23);
                list.Add(54654654);
                for(int i = 0; i < list._count; i++)
                {
                    Console.WriteLine("list[{0}] = {1}", i, list[i]);
                }
                Console.WriteLine("===============================================");
                bool test = list.Remove(589);
                Console.WriteLine("Remove 589");
                if (!test)
                    Console.WriteLine("없는 값 입니다.");
                for (int i = 0; i < list._count; i++)
                {
                    Console.WriteLine("list[{0}] = {1}", i, list[i]);
                }
                Console.WriteLine("===============================================");
                Console.WriteLine("Remove A");
                bool test2 = list.Remove("A");
                if (!test2)
                    Console.WriteLine("없는 값 입니다.");
                for (int i = 0; i < list._count; i++)
                {
                    Console.WriteLine("list[{0}] = {1}", i, list[i]);
                }
                Console.WriteLine("===============================================");
                Console.WriteLine("RemoveAt 2");
                bool test3 = list.RemoveAt(2);
                if (!test3)
                    Console.WriteLine("없는 인덱스 입니다.");
                for (int i = 0; i < list._count; i++)
                {
                    Console.WriteLine("list[{0}] = {1}", i, list[i]);
                }
                Console.WriteLine("===============================================");
                Console.WriteLine("Insert 2, 38777");
                list.Insert(2, 38777);
                for (int i = 0; i < list._count; i++)
                {
                    Console.WriteLine("list[{0}] = {1}", i, list[i]);
                }
                Console.WriteLine("===============================================");
                Console.WriteLine("Reverse");
                list.Reverse();
                for (int i = 0; i < list._count; i++)
                {
                    Console.WriteLine("list[{0}] = {1}", i, list[i]);
                }*/

            /*            CIStack<int> stack = new CIStack<int>();
                stack.Push(1);
                stack.Push(2);
                stack.Push(56);
                stack.Push(513);
                Console.WriteLine("=========================");
                Console.WriteLine("Push 1 , 2, 56, 513");
                for (int i = 0; i < stack._count; i++)
                    Console.WriteLine("stack[{0}] = {1}", i, stack[i]);
                Console.WriteLine("=========================");
                int pop = stack.Pop();
                Console.WriteLine("Pop = {0}", pop);
                int pop2 = stack.Pop();
                Console.WriteLine("Pop = {0}", pop2);
                for (int i = 0; i < stack._count; i++)
                    Console.WriteLine("stack[{0}] = {1}", i, stack[i]);
                Console.WriteLine("=========================");
                Console.WriteLine("=========================");
                Console.WriteLine("=========================");

                LinkedStack<int> stack2 = new LinkedStack<int>();
                stack2.Push(1);
                stack2.Push(2);
                stack2.Push(56);
                stack2.Push(513);
                Console.WriteLine("=========================");
                Console.WriteLine("Push 1 , 2, 56, 513");
                for (int i = 0; i < stack2._count; i++)
                    Console.WriteLine("stack[{0}] = {1}", i, stack2[i]);
                Console.WriteLine("=========================");
                int pop3 = stack2.Pop();
                Console.WriteLine("Pop = {0}", pop3);
                int pop4 = stack2.Pop();
                Console.WriteLine("Pop = {0}", pop4);
                for (int i = 0; i < stack2._count; i++)
                    Console.WriteLine("stack[{0}] = {1}", i, stack2[i]);
                Console.WriteLine("=========================");*/

            /*           CIHeapTree tree = new CIHeapTree();

                tree.add(2, "가나다");
                tree.add(4, "라마바");
                tree.add(6, "사아자");
                tree.add(7, "차카타");
                tree.add(8, "파하하");
                tree.add(10, "치키차");
                tree.add(11, "카초코");
                tree.add(13, "나쁜일");
                tree.add(15, "을하면");
                tree.add(3, "제발 되게 해주세요");

                Console.WriteLine("=====================================");
                tree.LevelOrder();

                tree.remove(6);


                Console.WriteLine("=====================================");
                tree.LevelOrder();

                Console.WriteLine("=====================================");
                tree.RemovePrint();
                Console.ReadKey();*/

            /*            CIAVLTree avl = new CIAVLTree();
                avl.Insert(2, "가나");
                avl.Insert(4, "다라");
                avl.Insert(3, "마바");
                avl.Insert(6, "사아");
                avl.Insert(50, "자차");
                avl.Insert(7, "카타");
                bool check2 = avl.Delect(4);
                if(check2)
                {
                    Console.WriteLine("삭제되었습니다.");
                }
                object test = null;
                bool check = avl.Search(50,ref test);
                Console.WriteLine("50의 값은 {0}", test);*/

            /*CIAVLTree avl = new CIAVLTree();
            avl.insert(6, "가나");
            avl.insert(7, "다라");
            avl.insert(8, "마바");
            avl.insert(10, "사아");
            avl.insert(12, "자차");
            avl.insert(11, "카타");
            avl.insert(13, "파하"); 
            avl.traverse();*/

            CIAVLTree<string, int> avlstr = new CIAVLTree<string, int>();

            avlstr.insert("가나", 5);
            avlstr.insert("다라마", 7);
            avlstr.insert("바사아자", 15);
            avlstr.insert("검정고무신", 15);
            avlstr.insert("skungs", 18);
            avlstr.traverse();
            avlstr.Delete("skungs");
            avlstr.traverse();
        }
    }
}
