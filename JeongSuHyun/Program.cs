using System;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace JeongSuHyun
{
    public enum blood_type
    {
        O형 = 0,
        A형,
        B형,
        AB형,

        Max
    }
    internal class Program
    {
      

        static Random rd = new Random();
        static void Main(string[] args)
        {
            StudentInfo[] studentInfo = new StudentInfo[7];
            bool dup_name = false;
            int check_apply = 0;
            while (true)
            {
                Console.WriteLine("1.입력");
                Console.WriteLine("2.출력");
                Console.WriteLine("3.나가기");
                Console.Write("번호를 입력하세요 : ");
                int check_num = int.Parse(Console.ReadLine());
                if (check_num == 1)
                {
                    if (studentInfo[0] == null)
                    {
                        Console.Write("이름을 입력하세요 : ");
                        string name = Console.ReadLine();
                        Console.Write("학급 반을 입력하세요 : ");
                        int group = int.Parse(Console.ReadLine());
                        int number = 1;
                        Console.Write("1.O형, 2.A형, 3.B형, 4.AB형\n혈액형을 입력하세요 : ");
                        int blood = int.Parse(Console.ReadLine()) - 1;
                        Console.Write("키를 입력하세요 : ");
                        float cm = float.Parse(Console.ReadLine());
                        Console.Write("몸무게를 입력하세요 : ");
                        float kg = float.Parse(Console.ReadLine());
                        studentInfo[check_apply] = new StudentInfo(name, group, number, blood, cm, kg, rd.Next(35, 101), rd.Next(35, 101), rd.Next(35, 101), rd.Next(35, 101));
                        check_apply++;
                    }
                    else
                    {
                        string name;
                        while (true)
                        {
                            dup_name = false;
                            Console.Write("이름을 입력하세요 : ");
                            name = Console.ReadLine();
                            for (int i = 0; i < check_apply; i++)
                            {
                                if (name.Equals(studentInfo[i]._name))
                                {
                                    dup_name = true;
                                    Console.WriteLine("중복된 이름입니다. 다시 입력해 주세요.");
                                }
                            }
                            if(!dup_name)
                            {
                                break;
                            }
                        }
                        Console.Write("학급 반을 입력하세요 : ");
                        int group = int.Parse(Console.ReadLine());
                        int number = 1;
                        for (int i = 0; i< check_apply; i++)
                        {
                            if (group == studentInfo[i]._group)
                            {
                                number++;
                            }
                        }
                        Console.Write("1.O형, 2.A형, 3.B형, 4.AB형\n혈액형을 입력하세요 : ");
                        int blood =  int.Parse(Console.ReadLine()) - 1;
                        Console.Write("키를 입력하세요 : ");
                        float cm = float.Parse(Console.ReadLine());
                        Console.Write("몸무게를 입력하세요 : ");
                        float kg = float.Parse(Console.ReadLine());
                        studentInfo[check_apply] = new StudentInfo(name, group, number, blood, cm, kg, rd.Next(35, 101), rd.Next(35, 101), rd.Next(35, 101), rd.Next(35, 101));
                        for (int i = 0; i < check_apply + 1; i++)
                        {
                            for (int j = 0; j < check_apply + 1; j++)
                            {
                                studentInfo[i]._rank = 1;
                            }
                        }
                        for (int i = 0; i < check_apply + 1; i++)
                        {
                            for (int j = 0; j < check_apply + 1; j++)
                            {
                                if (studentInfo[i]._aver < studentInfo[j]._aver)
                                {
                                    studentInfo[i]._rank++;
                                }
                            }
                        }
                        check_apply++;
                    }
                }
                else if (check_num == 2)
                {
                    Console.WriteLine("1. 전체 출력");
                    Console.WriteLine("2. 지정 출력");
                    Console.Write("번호를 입력하세요 : ");
                    int check_num2 = int.Parse(Console.ReadLine());
                    if (check_num2 == 1)
                    {
                        Console.WriteLine("1. 석차 순 출력");
                        Console.WriteLine("2. 학번 순 출력");
                        Console.Write("번호를 입력하세요 : ");
                        int check_num3 = int.Parse(Console.ReadLine());
                        if (check_num3 == 1)
                        {
                            int[] order_rank = new int[7] { 1, 2, 3, 4, 5, 6, 7};
                            for(int i = 0; i < check_apply; i++)
                            {
                                for(int j = 0; j < check_apply; j++)
                                {
                                    if (order_rank[i] == studentInfo[j]._rank)
                                    {
                                        all_ShowInfo(studentInfo[i]);
                                    }
                                }
                            }
                        }
                        else if (check_num3 == 2)
                        {
                            int[] group = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
                            int number = 0;
                            int[] check = new int[7] { 1, 2, 3, 4, 5, 6, 7 }; ;
                            int[,] gr_num = new int[7, 7] { {0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 },{ 0, 0, 0, 0, 0, 0, 0 },{ 0, 0, 0, 0, 0, 0, 0 },{ 0, 0, 0, 0, 0, 0, 0 } };
                            for (int i = 0; i < group.Length; i++)
                            {
                                number = 0;
                                for (int j = check_apply - 1; j >= 0; j--)
                                {
                                    if (group[i] == studentInfo[j]._group)
                                    {
                                        gr_num[i, number] = j + 1;
                                        number++;
                                    }
                                }
                            }
                            for(int i = 0; i < 7; i++)
                            {
                                for(int j = 0; j < 7; j++)
                                {
                                    for(int k = 0; k < check_apply; k++)
                                    {
                                        if (gr_num[i, k] != 0 && studentInfo[gr_num[i, k] - 1]._number == check[j])
                                        {
                                            all_ShowInfo(studentInfo[gr_num[i, k] - 1]);
                                        }
                                    }
                                        
                                }
                            }
                        }
                    }
                    else if (check_num2 == 2)
                    {
                        Console.WriteLine("1. 이름 지정 출력");
                        Console.WriteLine("2. 석차 지정 출력");
                        Console.Write("번호를 입력하세요 : ");
                        int check_num3 = int.Parse(Console.ReadLine());
                        if (check_num3 == 1)
                        {
                            Console.Write("이름을 입력하세요. : ");
                            string name = Console.ReadLine();
                            for(int i = 0; i < check_apply; i++)
                            {
                                if (name.Equals(studentInfo[i]._name))
                                {
                                    all_ShowInfo(studentInfo[i]);
                                }
                            }
                        }
                        else if (check_num3 == 2)
                        {
                            Console.Write("석차를 입력하세요. : ");
                            int rank = int.Parse(Console.ReadLine());
                            for (int i = 0; i < check_apply; i++)
                            {
                                if (rank == studentInfo[i]._rank)
                                {
                                    all_ShowInfo(studentInfo[i]);
                                }
                            }
                        }
                    }
                }
                else if (check_num == 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\n잘못된 입력입니다. 다시 입력해 주세요.\n");
                }
            }
        }
        static void all_ShowInfo(StudentInfo studentInfo)
        {
            Console.WriteLine("====[{0}]님의 정보 ======", studentInfo._name);
            Console.WriteLine("이름 : {0}", studentInfo._name);
            Console.WriteLine("반 : {0}", studentInfo._group);
            Console.WriteLine("번호 : {0}", studentInfo._number);
            Console.WriteLine("혈액형 : {0}", (blood_type)studentInfo._blood);
            studentInfo.score_ShowInfo();
        }
    }
}
