using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Learn_DataStructure
{
    /* Stack
     * LIFO의 형태로 구성
     * 컴퓨터 내에 메모리 관리 용도로 많이 사용
     * Array & Linked List를 이용
     */
    class CIStack<T>
    {
        T[] _datas;
        int _cnt = 0;

        public CIStack()
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

        public void Push(T element)
        {
            if (_cnt == 0)
            {
                _datas = new T[2];
            }
            else
            {
                if (_cnt == _capacity)
                    Array.Resize(ref _datas, _datas.Length * 2);

                for(int i = _cnt - 1; i >= 0; i --)
                {
                    _datas[i + 1] = _datas[i];
                }
            }
            _datas[0] = element;
            _cnt++;
        }

        public T Pop()
        {
            T ret = _datas[0];

            for (int i = 0; i < _cnt - 1; i++)
            {
                _datas[i] = _datas[i + 1];
            }
            _cnt--;
            return ret;
        }


        public object Top()
        {
            return _datas[_cnt - 1];
        }//최상단 element 반환 마지막 값

        public T this[int index]
        {
            get
            {
                return _datas[index];
            }
        }

    }
    public class St_node<T>
    {
        public T _value;
        public St_node<T> _next;

        public St_node()
        {
            this._value = default(T);
            this._next = null;
        }
    }

    class LinkedStack<T>
    {
        St_node<T> _head;
        int _cnt;

        public int _count { get { return _cnt; } }
        public bool _isEmpty { get { return _cnt == 0; } }

        public LinkedStack()
        {
            _head = null;
            _cnt = 0;
        }

        public void Push(T element)
        {
            St_node<T> node = new St_node<T>();
            node._value = element;
            if (_cnt == 0)
                _head = node;
            else
            {
                St_node<T> tail = _head;
                node._next = tail;
                _head = node;
                
            }
            _cnt++;
            //맨 끝에 붙어야됌
        }

        public T Pop()
        {
            T element = _head._value;
            St_node<T> NewHead = _head._next;
            _head = NewHead;
            _cnt--;
            return element;
        }


        public object Top()
        {
            St_node<T> search = _head;
            for (int i = 0; i < _cnt; i++)
                search = search._next;
            return search._value;
        }//최상단 element 반환 마지막 값

        public T this[int index]
        {
            get
            {
                St_node<T> Search = _head;
                for (int i = 0; i < index; i++)
                {
                    Search = Search._next;
                }
                T t = Search._value;
                return t;
            }
            set
            {
                St_node<T> Search = _head;
                for (int i = 0; i < index; i++)
                {
                    Search = Search._next;
                }
                Search._value = value;
            }
        }

    }
}
