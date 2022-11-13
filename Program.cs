using System.Xml.Serialization;

namespace HashTable
{
    class Program
    {
        public static void Main(string[] args)
        {







            //BinarySearchTree USECASE- 1, 2, 3
            Console.WriteLine("Binary tree");
            BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);
            binarySearch.Insert(30);
            binarySearch.Insert(70);
            binarySearch.Insert(22);
            binarySearch.Insert(40);
            binarySearch.Insert(60);
            binarySearch.Insert(95);
            binarySearch.Insert(11);
            binarySearch.Insert(65);
            binarySearch.Insert(3);
            binarySearch.Insert(16);
            binarySearch.Insert(63);
            binarySearch.Insert(67);
            binarySearch.Display();
            binarySearch.GetSize();
            bool result = binarySearch.IfExists(67, binarySearch);
            Console.WriteLine(result);
            
        }
        class BinarySearchTree<T> where T: IComparable<T>
        {
            public T NodeData { get; set; }
            public BinarySearchTree<T> LeftTree { get; set; }
            public BinarySearchTree<T> RightTree { get; set; }
            public BinarySearchTree(T nodeData)
            {
                this.NodeData = nodeData;
                this.LeftTree = null;
                this.RightTree = null;
            }
            int leftCount = 0, rightCount = 0;
            bool result = false;
            public void Insert(T item)
            {
                T CurrentNodeValue = this.NodeData;
                if ((CurrentNodeValue.CompareTo(item))>0)
                {
                    if (this.LeftTree == null)
                        this.LeftTree = new BinarySearchTree<T>(item);
                }
                else
                {
                    if (this.RightTree == null)
                        this.RightTree = new BinarySearchTree<T>(item);
                    else
                        this.RightTree.Insert(item);
                }

            }
            public void Display()
            {
                if(this.LeftTree != null)
                {
                    this.leftCount++;
                    this.LeftTree.Display();
                }
                Console.WriteLine(this.NodeData.ToString());
                if(this.RightTree != null)
                {
                    this.rightCount++;
                    this.RightTree.Display();
                }
            }
            public void GetSize()
            {
                Console.WriteLine("Size" + " " + (1 + this.leftCount + this.rightCount));
            }
            public bool IfExists(T element, BinarySearchTree<T> node)
            {
                if(node==null)
                {
                    return false;
                }
                if(node.NodeData.Equals(element))
                {
                    Console.WriteLine("Found the element in BinarySearchTree" + " " + node.NodeData);
                    return true;
                }
                else
                {
                    Console.WriteLine("Current element is {0} in BinarySearchTree", node.NodeData);
                }
                if (element.CompareTo(node.NodeData)<0)
                {
                    IfExists(element, node.LeftTree);
                }
                if (element.CompareTo(node.NodeData)>0)
                {
                    IfExists(element, node.RightTree);
                }
                return result;
            }
           
        }    
    }
}