using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Learn_DataStructure
{
    /* Queue
    * First In First Out의 형태로 구성되어 있음
    * 실생활과 컴퓨터에서 사용
    * Array를 이용한 구현 + Linked List를 이용한 구현 가능
    * Array = 1 resize 계속하며 값추가 LinkedList = 2
    */

    class CIQueue
    {
        object[] _datas;
        int _cnt = 0;

        public CIQueue()
        {
            _datas = null;
        }

        public int _capacity // 최대 크기
        {
            get { return _datas.Length; }
        }

        public int _count
        {
            get { return _cnt; }
        }

        public bool _isEmpty
        {
            get { return _datas.Length == 0; }
        }

        public void Enqueue(object obj)
        {
            if (_cnt == 0)
            {
                _datas = new object[2];
                _datas[0] = obj;
            }
            else
            {
                if(_cnt == _datas.Length)
                    Array.Resize(ref _datas, _datas.Length * 2);
                _datas[_cnt] = obj;
            }
            _cnt++;
        }
        public object Dequeue()
        {
            object obj = _datas[0];
            for(int i = 0; i < this._capacity - 1; i++)
            {
                _datas[i] = _datas[i + 1];
                _datas[i + 1] = null;
            }
            _cnt--;
            return obj;
        }

        public object front()
        {
            return _datas[0];
        }

        public object back() 
        {
            return _datas[_capacity - 1];
        }
    }

    public class Qu_node
    {
        public object _value;
        public Qu_node _next;

        public Qu_node()
        {
            this._value = null;
            this._next = null;
        }
    }

    class LinkedQueue
    {
        Qu_node _head;
        int _cnt;

        public int _count { get { return _cnt; }  }
        public bool _isEmpty{ get { return _cnt == 0; } }

        public LinkedQueue()
        {
            _head = null;
            _cnt = 0;
        }

        public void Enqueue(object element)
        {
            Qu_node node = new Qu_node();
            node._value = element;
            if (_cnt == 0)
                _head = node;
            else if(_cnt == 1)
            {
                _head._next = node;
            }
            else
            {
                Qu_node search = _head;
                for (int i = 0; i < _cnt; i++)
                    search = search._next;
                search._next = node;
            }
            _cnt++;
            //맨 끝에 붙어야됌
        }

        public object Dequeue() 
        {
            object obj = _head._value;
            Qu_node Newhead = _head._next;
            _head._next = null;
            _head._value = null;
            _head = Newhead;
            _cnt--;
            return obj;
        }

        public object front()
        {
            object obj = _head._value;
            return obj;
        }

        public object back()
        {
            Qu_node search = _head;
            for(int i = 0; i < _cnt; i++)
            {
                search = search._next;                
            }
            object obj = search._value;
            return obj;
        }
    }

    class CIQueue<T>
    {
        T[] _datas;
        int _cnt = 0;

        public CIQueue()
        {
            _datas = null;
        }

        public int _capacity // 최대 크기
        {
            get { return _datas.Length; }
        }

        public int _count
        {
            get { return _cnt; }
        }

        public bool _isEmpty
        {
            get { return _datas.Length == 0; }
        }

        public void Enqueue(T obj)
        {
            if (_cnt == 0)
            {
                _datas = new T[2];
                _datas[0] = obj;
            }
            else
            {
                if (_cnt == _datas.Length)
                    Array.Resize(ref _datas, _datas.Length * 2);
                _datas[_cnt] = obj;
            }
            _cnt++;
        }
        public object Dequeue()
        {
            object obj = _datas[0];
            for (int i = 0; i < this._capacity - 1; i++)
            {
                _datas[i] = _datas[i + 1];
                _datas[i + 1] = default(T);
            }
            _cnt--;
            return obj;
        }

        public object front()
        {
            return _datas[0];
        }

        public object back()
        {
            return _datas[_capacity - 1];
        }
    }

}
