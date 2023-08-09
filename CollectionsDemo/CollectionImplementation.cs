using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    public class CollectionImplementation
    {
        public void ListDemo()
        {
            Console.WriteLine("Proceeding with List");
            List<string> list = new List<string>();
            list.Add("a");
            list.Add("b");
            list.Add("c");
            foreach (var data in list)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine();
            list.Remove("c");
            foreach (var data in list)
            {
                Console.WriteLine(data);
            }
        }
        public void StackDemo()
        {
            Console.WriteLine("Proceeding with Stack");
            Stack<string> stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");
            foreach (var data in stack)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine();
            stack.Pop();
            foreach (var data in stack)
            {
                Console.WriteLine(data);
            }
        }
        public void QueueDemo()
        {
            Console.WriteLine("Proceeding with Queue");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("a");
            queue.Enqueue("b");
            queue.Enqueue("c");
            foreach (var data in queue)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine();
            queue.Dequeue();
            foreach (var data in queue)
            {
                Console.WriteLine(data);
            }

            //As per the PDF
            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            Console.WriteLine("Using Enumerator");
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        public void DictionaryDemo()
        {
            Console.WriteLine("Proceeding with Dictionary");
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "a");
            dict.Add(2, "b");
            dict.Add(3, "c");
            foreach (var data in dict)
            {
                Console.WriteLine(data.Key);
                Console.WriteLine(data.Value);
            }
            Console.WriteLine("List in Dictionary");
            Dictionary<int, List<string>> listDict = new Dictionary<int, List<string>>();
            List<string> listData = new List<string>();
            listData.Add("a");
            listData.Add("b");
            listData.Add("c");
            listDict.Add(4, listData);
            foreach (var item in listDict)
            {
                Console.WriteLine(item.Key);
                foreach(var data in item.Value)
                {
                    Console.WriteLine(data);
                }
            }
        }
        public void SetDemo()
        {
            Console.WriteLine("Proceeding with Set");
            var set = new HashSet<string>();
            set.Add("a");
            set.Add("b");
            set.Add("c");
            set.Add("a");
            foreach(var data in set)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine("Using Enumerator"); 
            HashSet<string>.Enumerator enumerator = set.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
    }
}
