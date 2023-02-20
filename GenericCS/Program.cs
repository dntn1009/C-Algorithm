using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCS
{
    internal class Program
    {
        static Random rd = new Random();

        static void Main(string[] args)
        {
            /* 일반화는 특수한 개념으로부터 공통된 개념을 찾아 묶는 것이다.
             * 일반화는 기능은 이미 결정되어 있고 자료형이 정하지 않고 만들어지는 특징이 있다.
             * 
             *  ArrayList       =>      List<T>      
             *  Queue           =>      Queue<T>
             *  Stack           =>      Stack<T>
             *  Hashtable       =>      Dicitionary<TKey,Tvalue>
             *  
             *  LinkedList는 선형 자료 구조이다.
             *  node(value & Link)를 요소로 node 끼리의 결합 형태를 가지고 있다.
             *  LinkedList는 삽입, 삭제가 다른 자료 구조에 비해 빠르다. (first = Head,end = Tail)
             *  단일은 뒤로 X 더블은 앞뒤로 O (이동) Circle로 Head와 Tail이 연결되어있을 시 Current만 존재
             */

            /*int su1 = 34, su2 = 1298;
            string word1 = "hello", word2 = "to hel";
            Console.WriteLine("su1 = {0}, su2 = {1}", su1, su2);
            ExchangeValue<int>(ref su1, ref su2);
            Console.WriteLine("su1 = {0}, su2 = {1}", su1, su2);
            Console.WriteLine("======================================");
            Console.WriteLine("word1 = {0}, word2 = {1}", word1, word2);
            ExchangeValue<string>(ref word1,ref word2);
            Console.WriteLine("word1 = {0}, word2 = {1}", word1, word2);*/

            /*int[] ori_num = new int[5] { 0, 1, 2, 3, 4 };
            int[] tar_num = new int[5];
            int[] target;
            ExchangeArrayValue<int>(ref ori_num, ref tar_num);
            for (int i = 0; i < ori_num.Length; i++)
            {
                Console.WriteLine("su1 = {0}, su2 = {1}", ori_num[i], tar_num[i]);
            }*/

            /*MyList<int> ltInt = new MyList<int>();
            ltInt.Add(rd.Next());
            ltInt.Add(rd.Next());
            ltInt.Add(rd.Next());

            for(int i =0; i < ltInt._count; i++) 
            {
                int v = 0;
                ltInt.GetValue(i, out v);
                Console.WriteLine("ltInt[{0}] = {1}", i, v);
            }*/

            LinkedList<int> ilt = new LinkedList<int>();
            ilt.AddLast(99);
            ilt.AddLast(194);
            ilt.AddLast(65535);
            ilt.AddLast(1);
            foreach(int el in ilt)
            {
                Console.WriteLine("el = {0}", el);
            }
            Console.WriteLine("=====================");
            if(ilt.Remove(194))
                Console.WriteLine("194가 지워졌습니다.");
            else
                Console.WriteLine("194는 없는 데이터 입니다.");
            /*LinkedListNode<int> samp = ilt.First;
            while(samp != null)
            {
                Console.WriteLine("current value = {0}", samp.Value);
                samp = samp.Next;
            }*/
            for(LinkedListNode<int> samp = ilt.First; samp != null; samp = samp.Next)
                Console.WriteLine("current value = {0}", samp.Value);

            system("pause");
        }

        static void CopyArray<T>(T[] source, T[] target)
        {
            for (int i = 0; i < source.Length; i++) 
            {
                target[i] = source[i];
            };
        }
        static void ExchangeArrayValue<T>(ref T[] val1, ref T[] val2)
        {

            val2 = new T[val1.Length];
            T[] temp = val1;
            val2 = temp;
        }

        static void ExchangeValue<T>(ref T val1, ref T val2)
        {
            T temp = val1;
            val1 = val2;
            val2 = temp;
        }

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
