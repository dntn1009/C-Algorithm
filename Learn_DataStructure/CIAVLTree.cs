using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Learn_DataStructure
{
    //230106 수업
    // 바이너리 서치 집가서 만들기
    // => 왼쪽값보다 크고 오른쪽값보다 작은 부모노드
    // 오름차순 정렬
    /* AVL 균형탐색 이진트리
     * 균형이진트리 대표적 방법
     * Internal node v에 대해 subtree의 height값의 차이가 최대1만큼 나도록 하는 트리
     * 밑에 자식 손자 까지 포함해서 높이가 최대 1차이가 나도록 하는것
     * log_2 (n) => 트리의 높이
     * n(h) = 1 + n(h-1) + n(h-2) == > n > 2 의 경우 AVL tree의 subtree의 height는 n - 1 과 n - 2 로 구분 지을 수 있으므로 전 점화식 유도 가능
     * 
     * balance force = left(h) - right(H)
     * 
     * 오른쪽 직렬
     * 1 - 1 - 1 (a, b, c) = > 1 - 2 - 0 (b, (a,c) , 0)
     * 
     * 왼쪽 직렬
     * 1 - 1 - 1 (a, b, c) = > 1 - 2 - 0 (b, (a,c) , 0)
     * 
     * 더블 로테이션
     * 
     * 플러스 오른쪽 마이너스 왼쪽(바이너리 서치에도 되는지 확인)
     * 
     * AVL 제거
     * 삭제된 부모의 부모 노드의 중립이 깨진 경우 작업을 진행해야한다.
     * height를 가진  node가 있는게 좋다.
     */
    /* 길찾기  의사코드
     * OPEN => 평가할 노드 집합
     * CLOSED => 이미 평가된 노드 집합
     * OPEN에 시작 노드 추가
     * 
     * loop
     *      current = f cost가 가장 낮은 OPEN의 노드
     *      OPEN에서 현재노드제거
     *      CLOSED에 현재노드 추가
     *      
     *      현재 노드가 대상 노드인 경우 // 경로발견
     *      return
     *      
     *      foreach 현재 노드의 이웃노드
     *      이웃노드가 순회할 수 없거나 이웃 노드가 closed에 있는 경우
     *      다음 이웃노드로 건너뛰기
     *      
     *      이웃노드에 대한 새 경로가 더 짧거나 이웃노드가  OPEN상태가 아닌 경우
     *      이웃노드의 f_cost 설정
     *      이웃노드의 부모를 현재로 설정
     *      이웃노드가 OPEn상태가 아닌 경우
     *      OPEN에 이웃노드 추가
     */

    public class AVL_node
    {
        public object _value;
        public int _key;
        public int _height;
        public AVL_node _left;
        public AVL_node _right;

        public AVL_node()
        {
            _value = null;
            _left = null;
            _right = null;
        }
    }

    public class CIAVLTree
    {
        AVL_node _Root;
        int _cnt;
        public CIAVLTree()
        {
            _Root = null;
            _cnt = 0;
        }

        public int height(AVL_node node)
        {
            if (node == null)
                return -1;
            return node._height;
        }// Rotation을 해야하기 때문에 높이를 알아야함

        public AVL_node rightRotation(AVL_node parent)
        {
            AVL_node Nparent = parent._left; //부모의 왼쪽 자식
            AVL_node nullnode = Nparent._right; // 새로운 부모(부모의 왼쪽자식)의 오른쪽 자식노드(null 임)

            Nparent._right = parent;//자식이 부모를 연결함.
            parent._left = nullnode;//기존의 부모 왼쪽은 당연히 null이 되어야함

            parent._height = Math.Max(height(parent._left), height(parent._right)) + 1;//회전한 전 부모의 높이 측정
            Nparent._height = Math.Max(height(Nparent._left), height(Nparent._right)) + 1; //회전한 새 부모의 높이 측정

            return Nparent; // 새로운 부모 노드
        }

        public AVL_node leftRotation(AVL_node parent)
        {
            AVL_node Nparent = parent._right; //부모의 오른쪽 자식
            AVL_node nullnode = Nparent._left; // 새로운 부모(부모의 오른쪽자식)의 왼쪽 자식노드(null 임)

            Nparent._left = parent;//자식이 부모를 연결함.
            parent._right = nullnode;

            parent._height = Math.Max(height(parent._left), height(parent._right)) + 1;//회전한 전 부모의 높이 측정
            Nparent._height = Math.Max(height(Nparent._left), height(Nparent._right)) + 1; //회전한 새 부모의 높이 측정

            return Nparent; // 새로운 부모 노드
        }


        public void insert(int key, object value)
        {
            _Root = insert(_Root, key, value);
        }

        private AVL_node insert(AVL_node node, int key, object value)
        {
            if (node == null)// Root인 경우 + null 인곳에 추가
            {
                AVL_node Inode = new AVL_node();
                Inode._key = key;
                Inode._value = value;
                Inode._height = 0;
                return Inode;
            }

            //재귀함수 이용하여 키가 더 크면 오른쪽으로 작으면 왼쪽으로 이동 후 함수 다시 부름
            if (key < node._key)
                node._left = insert(node._left, key, value);// null인곳에 추가 해주는 재귀함수
            else if (key > node._key)
                node._right = insert(node._right, key, value);// null인곳에 추가 해주는 재귀함수

            //노드를 추가시키면 높이 다시 갱신
            node._height = Math.Max(height(node._left), height(node._right)) + 1;

            // 추가 시킨 후에 트리가 불균형이면 Rotation 수행
            node = insertRotation(key, node);

            return node;
        }

        private AVL_node insertRotation(int key, AVL_node node)
        {
            int bf = balanceforce(node);

            if (bf > 1 && key < node._key)// 추가 된 노드가 상위 노드의 key보다 작은 경우 => 왼쪽노드
                return rightRotation(node);
            if (bf < -1 && key > node._key)// 추가 된 노드가 상위 노드의 key보다 큰 경우 => 오른쪽노드
                return leftRotation(node);

            if(bf > 1 && key > node._key)// 2번 회전
            {
                node._left = leftRotation(node._left);
                return rightRotation(node);
            }
            if(bf < -1 && key < node._key)
            {
                node._right = rightRotation(node._right);
                return leftRotation(node);
            }

            return node;
        }

        private int balanceforce(AVL_node node)
        {
            if (node == null)
                return 0;

            //1 < LL LR
            //-1 > RR RL
            return height(node._left) - height(node._right);
        }

        public void Delete(int key)
        {
            _Root = Delete(_Root, key);
        }

        private AVL_node Delete(AVL_node node, int key)
        {
            if (node == null)
                return node;

            if (key < node._key)
                node._left = Delete(node._left, key);
            else if (key > node._key)
                node._right = Delete(node._right, key);
            else
            {
                // 1. 삭제할 노드의 자식들이 null인 경우
                if (node._left == null && node._right == null)
                {
                    return null;
                }

                // 2. 삭제할 노드가 하나의 자식노드를 가진 경우
                if (node._left == null)// 오른쪽 자식만 있는 경우
                {
                    AVL_node temp1 = node._right;
                    node = null;
                    return temp1;
                }
                else if (node._right == null)
                {
                    AVL_node temp2= node._left;
                    node = null;
                    return temp2;
                }
                // 3. 삭제할 노드가 두개의 자식노드를 가진 경우
                AVL_node temp = getPredecessor(node._left, false);  // 왼쪽 자식노드 중에서 가장 큰 노드
                node._key = temp._key;
                node._value = temp._value;
                node._left = Delete(node._left, temp._key);
            }
            node._height = Math.Max(height(node._left), height(node._right)) + 1;

            return DeleteRotation(node);
        }

        private AVL_node DeleteRotation(AVL_node node)
        {
            int bf = balanceforce(node);
            
            if(bf > 1) // LL LR
            {
                //LR
                if(balanceforce(node._left) < 0)
                    node._left = leftRotation(node._left);
                return rightRotation(node);
            }

            if(bf < -1)// RR RL
            {
                //RL
                if (balanceforce(node._right) > 0) 
                    node._right = rightRotation(node._right);
                return leftRotation(node);
            }
            return node;
        }

        private AVL_node getPredecessor(AVL_node node, bool first)
        {
            if(node._left == null && node._right == null)
            {
                return node;
            }

            if(!first)
                if(node._right != null)
                {
                    node = getPredecessor(node._right, true);
                }
                else
                {
                    return node;   
                }
            else
            {
                if (node._right != null)
                    node = getPredecessor(node._right, true);
                else if (node._left != null)
                    node = getPredecessor(node._left, true);
                    
            }
            return node;
        }

        public void traverse()
        {
            if (_Root == null)
                return;

            Console.Write("Preorder Travel : ");
            PreorderTraversal(_Root, "[루]");
            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.Write("Inorder Travel : ");
            InOrderTraversal(_Root, "[루]");
            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.Write("Postorder Travel : ");
            PostorderTraversal(_Root, "[루]");
            Console.WriteLine();
            Console.WriteLine("========================================================");

        }

        //전위 순회
        public void PreorderTraversal(AVL_node node,string text)
        {
            Console.Write(text + node._key + node._value.ToString() + " ==> ");

            if (node._left != null)
                PreorderTraversal(node._left, text + "[왼]");
            if (node._right != null)
                PreorderTraversal(node._right, text + "[오]");   
        }

        // 중위 순회
        private void InOrderTraversal(AVL_node node, string text)
        {

            if (node._left != null)
                InOrderTraversal(node._left, text + "[왼]");

            Console.Write(text + node._key + node._value.ToString() + " ==> ");

            if (node._right != null)
            {
                InOrderTraversal(node._right, text + "[오]");
            }
        }

        //후위 순회
        private void PostorderTraversal(AVL_node node, string text)
        {
            if (node._left != null)
                PostorderTraversal(node._left, text + "[왼]");
            if (node._right != null)
                PostorderTraversal(node._right, text + "[오]");

            Console.Write(text + node._key + node._value.ToString() + " ==> ");
        }

    }

    public class AVL_node<T, U>
    {
        public U _value;
        public T _key;
        public int _height;
        public AVL_node<T, U> _left;
        public AVL_node<T, U> _right;

        public AVL_node()
        {
            _value = default(U);
            _key = default(T);
            _left = null;
            _right = null;
        }
    }

    public class CIAVLTree<T, U> where T : IComparable<T>
    {
        AVL_node<T, U> _Root;
        public CIAVLTree()
        {
            _Root = null;
        }

        public int height(AVL_node<T, U> node)
        {
            if (node == null)
                return -1;
            return node._height;
        }// Rotation을 해야하기 때문에 높이를 알아야함

        public AVL_node<T, U> rightRotation(AVL_node<T, U> parent)
        {
            AVL_node<T, U> Nparent = parent._left; //부모의 왼쪽 자식
            AVL_node<T, U> nullnode = Nparent._right; // 새로운 부모(부모의 왼쪽자식)의 오른쪽 자식노드(null 임)

            Nparent._right = parent;//자식이 부모를 연결함.
            parent._left = nullnode;//기존의 부모 왼쪽은 당연히 null이 되어야함

            parent._height = Math.Max(height(parent._left), height(parent._right)) + 1;//회전한 전 부모의 높이 측정
            Nparent._height = Math.Max(height(Nparent._left), height(Nparent._right)) + 1; //회전한 새 부모의 높이 측정

            return Nparent; // 새로운 부모 노드
        }

        public AVL_node<T, U> leftRotation(AVL_node<T, U> parent)
        {
            AVL_node<T, U> Nparent = parent._right; //부모의 오른쪽 자식
            AVL_node<T, U> nullnode = Nparent._left; // 새로운 부모(부모의 오른쪽자식)의 왼쪽 자식노드(null 임)

            Nparent._left = parent;//자식이 부모를 연결함.
            parent._right = nullnode;

            parent._height = Math.Max(height(parent._left), height(parent._right)) + 1;//회전한 전 부모의 높이 측정
            Nparent._height = Math.Max(height(Nparent._left), height(Nparent._right)) + 1; //회전한 새 부모의 높이 측정

            return Nparent; // 새로운 부모 노드
        }


        public void insert(T key, U value)
        {
            _Root = insert(_Root, key, value);
        }

        private AVL_node<T, U> insert(AVL_node<T, U> node, T key, U value)
        {
            if (node == null)// Root인 경우 + null 인곳에 추가
            {
                AVL_node<T, U> Inode = new AVL_node<T, U>();
                Inode._key = key;
                Inode._value = value;
                Inode._height = 0;
                return Inode;
            }

            //재귀함수 이용하여 키가 더 크면 오른쪽으로 작으면 왼쪽으로 이동 후 함수 다시 부름
            if(key.CompareTo(node._key) < 0)
                node._left = insert(node._left, key, value);// null인곳에 추가 해주는 재귀함수
            else if (key.CompareTo(node._key) > 0)
                node._right = insert(node._right, key, value);// null인곳에 추가 해주는 재귀함수

            //노드를 추가시키면 높이 다시 갱신
            node._height = Math.Max(height(node._left), height(node._right)) + 1;

            // 추가 시킨 후에 트리가 불균형이면 Rotation 수행
            node = insertRotation(key, node);

            return node;
        }

        private AVL_node<T, U> insertRotation(T key, AVL_node<T, U> node)
        {
            int bf = balanceforce(node);

            if (bf > 1 && key.CompareTo(node._key) < 0)// 추가 된 노드가 상위 노드의 key보다 작은 경우 => 왼쪽노드
                return rightRotation(node);
            if (bf < -1 && key.CompareTo(node._key) > 0)// 추가 된 노드가 상위 노드의 key보다 큰 경우 => 오른쪽노드
                return leftRotation(node);

            if (bf > 1 && key.CompareTo(node._key) > 0)// 2번 회전
            {
                node._left = leftRotation(node._left);
                return rightRotation(node);
            }
            if (bf < -1 && key.CompareTo(node._key) < 0)
            {
                node._right = rightRotation(node._right);
                return leftRotation(node);
            }

            return node;
        }

        private int balanceforce(AVL_node<T, U> node)
        {
            if (node == null)
                return 0;

            //1 < LL LR
            //-1 > RR RL
            return height(node._left) - height(node._right);
        }

        public void Delete(T key)
        {
            _Root = Delete(_Root,key);
        }

        private AVL_node<T, U> Delete(AVL_node<T, U> node, T key)
        {
            if (node == null)
                return node;

            if(key.CompareTo(node._key) < 0)
                node._left = Delete(node._left, key);
            else if (key.CompareTo(node._key) > 0)
                node._right = Delete(node._right, key);
            else
            {
                // 1. 삭제할 노드의 자식들이 null인 경우
                if (node._left == null && node._right == null)
                {
                    return null;
                }

                // 2. 삭제할 노드가 하나의 자식노드를 가진 경우
                if (node._left == null)// 오른쪽 자식만 있는 경우
                {
                    AVL_node<T, U> temp1 = node._right;
                    node = null;
                    return temp1;
                }
                else if (node._right == null)
                {
                    AVL_node<T, U> temp2 = node._left;
                    node = null;
                    return temp2;
                }
                // 3. 삭제할 노드가 두개의 자식노드를 가진 경우
                AVL_node<T, U> temp = getPredecessor(node._left, false);  // 왼쪽 자식노드 중에서 가장 큰 노드
                
                node._key = temp._key;
                node._value = temp._value;
                node._left = Delete(node._left, temp._key);
            }
            node._height = Math.Max(height(node._left), height(node._right)) + 1;

            return DeleteRotation(node);
        }

        private AVL_node<T, U> DeleteRotation(AVL_node<T, U> node)
        {
            int bf = balanceforce(node);

            if (bf > 1) // LL LR
            {
                //LR
                if (balanceforce(node._left) < 0)
                    node._left = leftRotation(node._left);
                return rightRotation(node);
            }

            if (bf < -1)// RR RL
            {
                //RL
                if (balanceforce(node._right) > 0)
                    node._right = rightRotation(node._right);
                return leftRotation(node);
            }
            return node;
        }

        private AVL_node<T, U> getPredecessor(AVL_node<T, U> node, bool first)
        {
            if (node._left == null && node._right == null)
            {
                return node;
            }

            if (!first)
                if (node._right != null)
                {
                    node = getPredecessor(node._right, true);
                }
                else
                {
                    return node;
                }
            else
            {
                if (node._right != null)
                    node = getPredecessor(node._right, true);
                else if (node._left != null)
                    node = getPredecessor(node._left, true);

            }
            return node;
        }

        public void traverse()
        {
            if (_Root == null)
                return;

            Console.Write("Preorder Travel : ");
            PreorderTraversal(_Root, "[루]");
            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.Write("Inorder Travel : ");
            InOrderTraversal(_Root, "[루]");
            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.Write("Postorder Travel : ");
            PostorderTraversal(_Root, "[루]");
            Console.WriteLine();
            Console.WriteLine("========================================================");

        }

        //전위 순회
        public void PreorderTraversal(AVL_node<T, U> node, string text)
        {
            Console.Write(text + node._key.ToString() + node._value.ToString() + " ==> ");

            if (node._left != null)
                PreorderTraversal(node._left, text + "[왼]");
            if (node._right != null)
                PreorderTraversal(node._right, text + "[오]");
        }

        // 중위 순회
        private void InOrderTraversal(AVL_node<T, U> node, string text)
        {

            if (node._left != null)
                InOrderTraversal(node._left, text + "[왼]");

            Console.Write(text + node._key.ToString() + node._value.ToString() + " ==> ");

            if (node._right != null)
            {
                InOrderTraversal(node._right, text + "[오]");
            }
        }

        //후위 순회
        private void PostorderTraversal(AVL_node<T, U> node, string text)
        {
            if (node._left != null)
                PostorderTraversal(node._left, text + "[왼]");
            if (node._right != null)
                PostorderTraversal(node._right, text + "[오]");

            Console.Write(text + node._key.ToString() + node._value.ToString() + " ==> ");
        }
    }

}
