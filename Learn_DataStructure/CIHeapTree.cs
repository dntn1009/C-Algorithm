using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Learn_DataStructure
{
    /* general tree terminology
    * 
    *  root 패런트가 없는 노드  = A 대빵
    *  internal node 자식이 있는 노드 뿌리 있는놈들
    *  external 자식이 없는 노드 뿌리 없음
    *  ancerstors 부모 그위에 존재하는 모든 노드
    *  depth 해당 노드부터 부모 노드까지 조상의 숫자(모든 자기위의 부모)
    *  height 최대 depth = 3
    *  descendant 해당 노드부터 모든 자식 노드
    *  subtree 어떤 노드 P부터 그 아래
    * 
    * Tree Basic alogorithm
    *  depth 구하기 아래에서 위로 부모가 없을때까지 확인하면 depth 확인 가능
    *  isRoot(V) => 부모 있는지 확인
    *  return 0 => 부모없음
    *  return 1 + depth(T, T.Parent(v)) => 부모가 있으면 depth 증가시키고 해당 부모의 노드 부름
    *  
    *  
    *  Height 구하기
    *  
    *  모든 exteranl 노드에 대하여 depth를 계산하여 구하는 방법
    *  T(노드).isExternal(v) 뿌리가 없는데까지 내려간 후에
    *  많이 내려간 depth를 height로 지정
    *  
    *  subtree의 height를 계산하여 구하는 방법
    *  isExternal로 내려간후에
    *  T.Children이 많은 노드의 depth = height
    *  max(h, depth(T, W))
    *  
    *  Tree interface Methods(Accessor)
    *  Root() = root node 반환
    *  Parent(v) = 해당 노드의 부모 노드 반환 루트노드는 부모 null
    *  Childern = Child node array를 반환 Leaf = external => children 값이 노말
    *  
    *  Tree interface Methods(Query)
    *  isInternal(v) = Internal 노드인지 확인
    *  isExternal(v) = External 노드인지 확인
    *  isRoot(v) = Root 인지 확인
    *  
    *  Generic
    *  Size()
    *  isEmpty()
    *  iterator() = 트리안의 모든 데이터 출력(여려가지 구현방식)
    *  positions()
    *  
    *  
    *  순환
    *  
    *  전위 = 위 - 왼 - 오
    *  후위 = 왼 - 오 - 위
    *  중위(inorder) = 왼 - 위 - 오
    *  레벨 = 위 - 왼 - 오 * 2
    *  
    *  gereneric tree treaversal
    *  
    *  Preorder Traversal (전위)
    *  데이터에  접근한 순서대로 node를 순회함
    *  Child node 접근 전에 해당 노드 v의 값 출력
    *  
    *  Postorder(후위)
    *  접근한 Node의 자손을 먼저 순회함
    *  Childe node에 대한 접근을 먼저 한 후 그후에 데이터를 출력
    *  ex)문서 출력
    *  
    *  Binary Tree
    *  internal node는 최대 2개의 자식(Proper은 무조건 2개)
    *  children = left, right(child)로 부름
    *  ex) 의사결정방법 Arithmetic expressions, 검색
    *  
    *  산술 표현
    *  Internal node = 연산자
    *  External node = 피연산자
    *  중위 전환을 씀
    *  
    *  의사 결정 과정
    *  Internal node = 예/아니오 질의(질문)
    *  External node = 선택지(대답)
    *  
    *  Binary Tree Methods List
    *  
    *  Accessor
    *  Left(v) = Node v의 왼쪽 child를 반환합니다. Child가 없으면 에러 발생
    *  Right(v) = 오른쪽 child를 반환합니다. ""
    *  
    *  Query
    *  hasLeft(v) = Left Child를 가지고 있는지 확인
    *  hasRight(v) = Right child를 가지고 있는지 확인
    *  
    *  Complete Binary Tree Methods
    *  Add(o) = Tree의 가장 왼쪽 external node 부터 채워 나간다. height가 가득찬 상태일 경우 height가 증가한다.
    *  Remove() : 마지막 node를 삭제합니다.
    *  
    *  Notation(표기)
    *  n : node의 수
    *  e : External node의 수
    *  i : Internal node의 수
    *  h : Tree의 높이
    *  
    *  Inorder Traversal
    *  접근한 Node의 자손, 접근한 Node, 오른쪽 자손 순서로 순회함.
    *  ex) 사칙연산
    *  if hasLeft(v)
    *       inOrder(Ic)
    *    visit(v)
    *  if hasRight(v)
    *    inOrder(Rc)
    *    
    *    *2 + 1 | * 2 + 2 
    *    
    *    포화  = 꽉 차있을 경우
    *    완전 = 꽉 안차있지만 형식을 따른 경우
    *    
    *    Heap
    *    Priority Queue에서 주로 사용
    *    Binary Tree에서 두개의 추가적인 조건을 만족
    *    1. Heap-order Property = root node가아닌 부모 노드의 값 <= 자식 노드(내림차순으로 정렬시 반대)
    *    up heap = 부모 노드의 값 > 자식노드 일 경우, 자식노드 와 부모노드를 바꾼다 이 행동을 루트노드까지 부모 노드의 값 <= 자식 노드가 되도록 변경시킨다.
    *    height 가 log_2n 이면 log_2 n 만큼 up heap이 동작한다.
    *    
    *    2. Complete Binary tree property = Tree의 높이에 따라 최대 node의 수가 결정, Complete Binary tree의 형태가 아니라면 좌에서 우로 순차적으로 node를 추가
    *    
    *    Heap 지우기 작업
    *    마지막 node를 Root 노드에 옮기고 마지막 노드에 있는 root값을 지운다.
    *    그후에 루트노드에 있는 값을 Down Heap 한다.
    *    DownHeap은 Upheap 과 같은 형식으로 내린다.
    *    
    *    Two heap 병합
    *    임의로 설정한 K를 Root 노드로 설정하고 두개의 Heap을 K의 자식 노드로 붙인다. 그리고 K를 Down Heap 한다.
    *    K가 없는 경우 가장 오른쪽 노드 하나를 위로 올려 보낸 후에 두개를 병합한다. 그리고 DOwn Heap을 한다.
    */

 


    public class HTnode
    {
        public int _key
        {
            get;set;
        }
        public object _value
        {
            get;set;
        }

        public HTnode(int k, object v)
        {
            _key = k;
            _value = v;
        }
    }


    class CIHeapTree
    {
        // 자료 저장소
        // 개수
        // capacity
        // add
        // remove
        // 레벨 순회 출력
        // 루트[,]
        // 왼[,] 오[,]
        // 왼왼[,] 왼오[,] 오왼[,] 오오[,]

        HTnode[] _node;
        int _cnt;

        public CIHeapTree()
        {
            _node = null;
            _cnt = 0;
        }


        public HTnode this[int index]
        {
            get { return _node[index]; }
        }

        public int _capacity { get { return _node.Length; } }
        public int _count { get { return _cnt; } }

        public void add(int key, object element)
        {
            if (_cnt == 0)
                _node = new HTnode[4];
            else
                if(_cnt == _node.Length)
                    Array.Resize(ref _node, _cnt * 2);

            _node[_cnt] = new HTnode(key, element);

            int count = _cnt;
            if (_node[(_cnt - 1) / 2]._key > _node[_cnt]._key)
            {
                for (int i = count; i > 0; i--)
                {
                    if (_node[(i - 1) / 2]._key > _node[i]._key)
                    {
                        HTnode node = _node[i];
                        _node[i] = _node[(i - 1) / 2];
                        _node[(i - 1) / 2] = node;
                    }
                }
            }
            _cnt++;
        }

        public bool remove(int key)
        {
            int re_height = 0;
            bool ret_chek = false;
            for (int i = 0; i < _count; i++)
            {
                if (_node[i]._key == key)
                {
                    _node[i] = _node[_count - 1];
                    _node[_count - 1] = null;
                    re_height = i;
                    ret_chek = true;
                    _cnt--;
                    break;
                }
            }
            int num = 0;
            for (int i = re_height; i < _cnt; i++)
            {
                if (i == re_height || i == num)
                    if (_node[i]._key > _node[i * 2 + 1]._key || _node[i]._key > _node[i * 2 + 2]._key)
                    {
                        if (_node[i * 2 + 2]._key < _node[i * 2 + 1]._key)
                        {
                            HTnode node = _node[i];
                            _node[i] = _node[i * 2 + 2];
                            _node[i * 2 + 2] = node;
                            num = i * 2 + 2;
                        }
                        else if (_node[i * 2 + 2]._key < _node[i * 2 + 1]._key)
                        {
                            HTnode node = _node[i];
                            _node[i] = _node[i * 2 + 1];
                            _node[i * 2 + 1] = node;
                            num = i * 2 + 1;
                        }
                    }
                    else
                        break;
            }
            return ret_chek;
        }

        public void RemovePrint()
        {
            Console.WriteLine("Root Key = {0}, Value = {1}", _node[0]._key, _node[0]._value);
            for (int i = 0; i < _cnt; i++) 
            {
                this.remove(0);
                Console.WriteLine("Root Key = {0}, Value = {1}", _node[0]._key, _node[0]._value);
                _cnt--;
            }
        }

        public void LevelOrder()
        {
            for (int i = 0; i < _cnt; i++)
            {
                if (i == 0)
                    Console.WriteLine("Root Key = {0}, Value = {1}", _node[i]._key, _node[i]._value);
                else if (i % 2 == 1)
                {
                    Console.WriteLine("왼쪽 Key = {0}, Value = {1}", _node[i]._key, _node[i]._value);
                }
                else if (i % 2 == 0)
                {
                    Console.WriteLine("오른쪽 Key = {0}, Value = {1}", _node[i]._key, _node[i]._value);
                }
            }
        }


    }
}
