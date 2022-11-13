//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HashTable
//{
//    public class MyMapNode<k, v> 
//    {
//        private readonly int size;
//        private readonly LinkedList<KeyValue<k, v>>[] items;

//        public MyMapNode(int size)
//        {
//            this.size = size;
//            this.items = new LinkedList<KeyValue<k, v>>[size];
//        }
//        protected int GetArrayPosition(k key)
//        {
//            int position = key.GetHashCode() % size;
//            return Math.Abs(position);
//        }
//        public v Get(k key)
//        {
//            int position = GetArrayPosition(key);
//            LinkedList<KeyValue<k, v>> linkedlist = GetLinkedList(position);

//            foreach (KeyValue<k, v> item in linkedlist)
//            {
//                if (item.key.Equals(key))
//                {
//                    return item.value;
//                }
//            }
//            return default(v);
//        }
//        public void Add(k key, v value)
//        {
//            int position = GetArrayPosition(key);
//            LinkedList<KeyValue<k, v>> linkedlist = GetLinkedList(position);
//            KeyValue<k, v> item = new KeyValue<k, v>(){key = key, value = value};
//            linkedlist.AddLast(item);
//        }
//        public void Remove(k key)
//        {
//            int position = GetArrayPosition(key);
//            LinkedList<KeyValue<k, v>> linkedlist = GetLinkedList(position);
//            bool itemfound = false;
//            KeyValue<k, v> foundItem = default(KeyValue<k, v>);
//            foreach (KeyValue<k, v> item in linkedlist)
//            {
//                if (item.key.Equals(key)) ;
//                {
//                    itemfound = true;
//                    foundItem = item;
//                }
//            } 
//            if (itemfound)
//            {
//                linkedlist.Remove(foundItem);
//            }
//        }

//        protected LinkedList<KeyValue<k, v>> GetLinkedList(int position) 
//        {
//            LinkedList<KeyValue<k, v>> linkedList = items(position);
//            if (linkedList == null)
//            {
//                linkedList = new LinkedList<KeyValue<k, v>>();
//                items(position) = linkedList;
//            }
//            return linkedList;

//        }
//        public struct KeyValue<k, v>
//        {
//           public k key { get; set; }
//           public v value { get; set; }
//        }



        
//    }
//}   
