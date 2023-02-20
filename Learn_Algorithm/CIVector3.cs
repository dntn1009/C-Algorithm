using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Algorithm
{
    class CIVector3
    {
        public float x
        {
            get; set;
        }
        public float y
        {
            get; set;
        }
        public float z
        {
            get; set;
        }

        public CIVector3()
        {
            x = 0;
            y = 0;
            z = 0;
        }
        public CIVector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static CIVector3 operator +(CIVector3 ci1, CIVector3 ci2)
        {
            return new CIVector3(ci1.x + ci2.x, ci1.y + ci2.y, ci1.z + ci2.z);
        }//벡터 합

        public static CIVector3 operator -(CIVector3 ci1, CIVector3 ci2)
        {
            return new CIVector3(ci1.x - ci2.x, ci1.y - ci2.y, ci1.z - ci2.z);
        }//벡터 차

        public static CIVector3 operator *(float a, CIVector3 ci)
        {
            return new CIVector3(ci.x * a, ci.y * a, ci.z * a);
        }
        public static CIVector3 operator *(CIVector3 ci, float a)
        {
            return new CIVector3(ci.x * a, ci.y * a, ci.z * a);
        }//스칼라 곱

        public float magnitude
        {
            get { return (float)Math.Sqrt((x * x) + (y * y) + (z * z)); }
        }//벡터의 크기
        public float distance(CIVector3 ci1, CIVector3 ci2)
        {
            CIVector3 distance = ci1 - ci2;
            return distance.magnitude;
        }//두 벡터간의 거리
        public void normalized()
        {
            float magnitude = this.magnitude;
            x = x / magnitude;
            y = y / magnitude;
            z = z / magnitude;
        }//노멀라이즈 정규화
        public CIVector3 Normalized
        {
            get { return new CIVector3(x / this.magnitude , y / this.magnitude, z / this.magnitude); }
        }// 노멀라이즈 프로퍼티

        public static float dotproduct(CIVector3 ci1, CIVector3 ci2)
        {
            return (ci1.x * ci2.x) + (ci1.y * ci2.y) + (ci1.z * ci2.z);
        }//내적 2개를 받아서 리턴

        public static CIVector3 crossproduct(CIVector3 ci1, CIVector3 ci2)
        {
            return new CIVector3((ci1.y * ci2.z) - (ci1.z * ci2.y), (ci1.z * ci2.x) - (ci1.x * ci2.z), (ci1.x * ci2.y) - (ci1.y * ci2.x));  
        }// 외적 리턴

        // v1 x v2 = (y1* z2 - z1* y2, z1 * x2 - x1* z2, x1* y2 - y1* x2)

    }
}
