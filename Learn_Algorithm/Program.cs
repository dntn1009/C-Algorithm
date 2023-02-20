using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Vector
             * x, y, z => 공간 벡터
             * x, y => 평면 벡터
             * Vector는 n개의 실수형 자료 가진 tuple(여러 요소들의 묶음)로 정의한다.
             * 일반적으로 n = 2, 3, 4
             * 벡터 간의 덧셈은 위치이동, 뺼셈은 목적지의 거리와 방향
             * V1.magnitude = sqrt((x1 * x1) + (y1 * y1))
             * Vector의 크기는 따로 norm 또는 length라고도 한다.
             * 
             * Vector1의 정규화
             * 정규화 되면 방향만 가진 Vector만 된다.
             * 크기가 1임
             *  V1 * a = V(x1 / V1.magnitude, y1 / V1.magnitude)
             * 
             * 내적
             * 두 벡터가 가리키는 방향의 차이를 연산으로 구함.
             * 결과값으로 스칼라값이 나옴.
             * 내적의 결과는 두벡터의 크기에 사이각의 연산과 같다.
             * v1 x v2
             * ex) 내 앞을 기준으로 양옆이 X축이라 한다면 앞의 180도 까지는 양수 뒤에서는 음수이기때문에
             *      뒤에 몬스터가 있는지 없는지 판별가능하다 뒤에 몬스터가있으면 음수가 뜨기때문
             * 
             * 외적(3차원 벡터만 존재)
             * 벡터곱이라고 함, 연산의 결과는 두벡터의 수직인 벡터가 생긴다.
             *  v1 x v2 = (y1 * z2 - z1 * y2, z1 * x2 - x1 * z2, x1* y2 - y1 * x2)
             * 
             * 스칼라곱
             * V1 * a = (x*a, y*a), a = 스칼라 값
             * 벡터와 스칼라간의 곱은 벡터의 힘의 크기 변화를 나타낸다.
             */

            /* Matrix => 행렬
             *  수 또는 다항식 등을 직사각형 모양으로 배열
             *  덧셈, 스칼라곱, 곱셈 연산이 존재
             *  순서쌍(m, n) m == n => 정사각 행렬 or 정방 행렬 (Mat(n:R), Mn(R))
             *  m == 1 행 벡터
             *  n == 1 열 벡터
             *  
             *  항등 관계 => 값은 같지만 위치가 다르면 항등관계가 아니다.
             *  
             *  덧셈, 뺼셈
             *  => m x n 이 같아야 가능함
             *  스칼라곱
             * => 벡터와 동일
             *  행렬의 곱셈
             *  차원이 달라도 가능하지만 적합성이 충족되어야한다(열개수와 뒤의 행개수가 같아야 연산이 가능)
             *  계산식 : 열 x 행 (1,1) = (1,1~3) * (1~3, 1) 각자 곱해서 더한걸 1,1에둔다
             *  
             *  단위 행렬
             *  => 대각선 방향(1,1) (2,2) 만나는 만나는 부분을 identity => Vector의 normalized 느낌임
             *  GPU => 4,4의 매트릭스 알고리즘을 빨리 연산하기 때문에 좋을수록 좋다.
             *  4.4 x, 3 까지는 방향 x, 4 까지는 위치 
             *  
             *  //
             *  
             *  전치 행렬
             *  열과 행의 위치를 바꿈 공용함수로 만들기
             *  
             *  역행렬
             *  (1 / ad-bc) *  {d, -b, -c, a}
             */
            /* CIVector2 V1 = new CIVector2(4, 3);
             CIVector2 V2 = new CIVector2(1, 6);

             int skala = 2;

             Console.WriteLine("V1 + V2 = {0}, {1}", (V1 + V2).x, (V1 + V2).y);
             Console.WriteLine("V1 - V2 = {0}, {1}", (V1 - V2).x, (V1 - V2).y);
             Console.WriteLine("scalar = 2, V1(scalar) = {0}, {1}", (V1 * skala).x, (V1 * skala).y);
             float magnitude = V1.magnitude();
             Console.WriteLine("V1.magnitude = {0}", magnitude);
             float distance = CIVector2.distance(V1, V2);
             Console.WriteLine("V1 and V2 Distance = {0}", distance);
             CIVector2 V1Normal = new CIVector2();
             V1Normal = V1.Normalized;
             Console.WriteLine("V1 normalized = {0}, {1}", V1Normal.x, V1Normal.y);
             Console.WriteLine("V1 and V2 내적 = {0}", CIVector2.dotproduct(V1, V2));
             V1.normalized();
             Console.WriteLine("V1 본인 normalized = {0}, {1}", V1.x, V1.y);*/

            /* 알고리즘 분석
             * 직접 코딩해서 case -by- case로 알고리즘의 속도를 판별해 분석하는 방법
             * 코딩해서 작동시켜보지않고 분석하는 방법
             * 
             * 실험적 분석 방법 한계
             * 제한된 테스트 입력값으로 정확한 측정이 어려움
             * 동작시간을 구분하기 어려움
             * 구현해야지만 가능함
             * 
             * 이론적 분석 방법
             * 입력 가능한 데이터들에 대해 분석 가능
             * 두 알고리즘의 성능을 비교, 분석 할때 분석환경의 영향을 제거할 수 있다.
             * 고수준 언어의 분석으로 실제 구현과 결과를 미리 분석 가능
             * 
             * 분석에 앞서 생각해야 하는것
             * 대부분의 알고리즘은 입력된 객체를 출력 객체로 변환.
             * 알고리즘 동작 시간은 입력데이터의 크기에 비례해 증가함
             * 평균 동작시간의 측정은 대다수가 매우 어려움
             * 최악의 런타임에 초점을 두어야함
             * 다음 작업들의 동작시간을 1로 정해둔다.
             * 변수할당
             * 함수 호출
             * 사칙연산
             * 비교
             * 배열접근
             * 포인터 추적
             * 메소드 동작 종료 후 반환
             * 의사코드 = 글로 써논 코드를 코드화 시키는것
             * 
             * 의사 코드(Pseude code)
             * 어떠한 알고리즘(동작)의 상위언어 표현입니다.
             * 영어의 형태보단 구조적
             * 실제 코드에 비해 자세하진 않음
             * 구동 방식 정리하는데 사용
             * 실제 프로그래밍에 들어가는 여러 트릭이나 기타 사항 무시 가능
             * 7개의 기본 함수 그래프
             * 1. f(n) = 1
             * 2. f(n) = log n
             * 3. f(n) = n
             * 4. f(n) = n log n
             * 5. f(n) = n^2
             * 6. f(n) = n^3
             * 7. f(n) = 2의n승
             * 
             * 동작 횟수 계산
             * 기능들의 동작 횟수를 계산하는것
             * n값의 증가에 따라 동작횟수가 변화하는 추이가 n값 이외의 상수의 영향보다 큽니다.
             * 
             * 정렬 알고리즘 : 삽입, 선택, 셀, 퀵, 합병
             * 비정렬 알고리즘 : 비둘기집, 버킷, LSD기수
             * 기타 정렬 알고리즘 : 스파게티 정렬, 바이토닉 정렬등
             */

            /*float[,] mat = new float[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    mat[i, j] = 2;
                }
            }*/
            /*            CIMatrix matrix1 = new CIMatrix();
                        CIMatrix matrix2 = new CIMatrix(2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2);
                        CIMatrix matrix3 = new CIMatrix(mat);
                        Console.WriteLine("기본 생성자");
                        Console.WriteLine(matrix1.ToString());
                        Console.WriteLine("초기화 생성자 float");
                        Console.WriteLine(matrix2.ToString());
                        Console.WriteLine("초기화 생성자 배열");
                        Console.WriteLine(matrix3.ToString());
                        Console.WriteLine("matrix2 zeroMatrix");
                        CIMatrix zero = CIMatrix.zeroMatrix(matrix2);
                        Console.WriteLine(zero.ToString());
                        Console.WriteLine("matrix1 + matrix2");
                        CIMatrix plus = matrix1 + matrix2;
                        Console.WriteLine(plus.ToString());
                        Console.WriteLine("matrix1 - matrix2");
                        CIMatrix minus = matrix1 - matrix2;
                        Console.WriteLine(minus.ToString());
                        Console.WriteLine("matrix1 * 스칼라");
                        CIMatrix skala = matrix1 * 16;
                        Console.WriteLine(skala.ToString());
                        Console.WriteLine("matrix2 * matrix3");
                        CIMatrix multiple = matrix2 * matrix3;
                        Console.WriteLine(multiple.ToString());
                        Console.WriteLine("matrix2 identity");
                        CIMatrix identity = matrix2.Identity;
                        Console.WriteLine(identity.ToString());
                        Console.WriteLine("matrix2 identity2");
                        matrix2.identity();
                        Console.WriteLine(matrix2);*/

            int[] testArr = { 32, 9, 15, 29, 174, 48 };
            /* PrintShowArray(testArr, "testArr");
             SortClass.SelectionSort(testArr, false);
             PrintShowArray(testArr, "testArr");*/
            /* PrintShowArray(testArr, "testArr");
             SortClass.insertionSort(testArr, false);
             PrintShowArray(testArr, "testArr");*/
            /*PrintShowArray(testArr, "testArr");
            SortClass.bubbleSort(testArr, false);
            PrintShowArray(testArr, "testArr");*/
            PrintShowArray(testArr, "testArr");
            SortClass.MergeSort(testArr, 0, 6);
            PrintShowArray(testArr, "testArr");


            Console.ReadKey();
        }

        public static void PrintShowArray<T>(T[] arr, string name)
        {
            Console.WriteLine("===========================");
            for (int n = 0; n < arr.Length; n++)
                Console.WriteLine("{0}[1] = {2}", name, n, arr[n]);
            Console.WriteLine("===========================");
        }
    }
}
