using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Algorithm
{
    class CIVector2
    {
        public float x
        {
            get;set;
        }
        public float y
        {
            get;set;
        }

        public CIVector2()
        {
            x = 0;
            y = 0;
        }

        public CIVector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }


        public static CIVector2 operator +(CIVector2 ci1, CIVector2 ci2)
        {
            return new CIVector2(ci1.x + ci2.x, ci1.y + ci2.y);
        }//벡터 합

        public static CIVector2 operator -(CIVector2 ci1, CIVector2 ci2)
        {
            return new CIVector2(ci1.x - ci2.x, ci1.y - ci2.y);
        }//벡터 차

        public static CIVector2 operator *(CIVector2 ci, float a)
        {
            return new CIVector2(ci.x * a, ci.y * a);
        }//스칼라 곱

        public float magnitude()
        {
            return (float)Math.Sqrt((x * x) + (y * y));
        }//벡터의 크기

        public static float distance(CIVector2 ci1, CIVector2 ci2)
        {
            CIVector2 distance = ci1 - ci2;
            return distance.magnitude();
        }//두 벡터간의 거리

        public void normalized()
        {
            float magnitude = this.magnitude();
            x = x / magnitude;
            y = y / magnitude;
        }//노멀라이즈 정규화

       public CIVector2 Normalized
        {
            get { return new CIVector2(x / (float)Math.Sqrt((x * x) + (y * y)), y / (float)Math.Sqrt((x * x) + (y * y))); }
        }// 노멀라이즈 프로퍼티


        public static float dotproduct(CIVector2 ci1, CIVector2 ci2)
        {
            return (ci1.x * ci2.x) + (ci1.y * ci2.y);
        }//내적 2개를 받아서 리턴

    }
}
