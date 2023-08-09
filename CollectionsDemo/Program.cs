using System;

namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CollectionImplementation collection = new CollectionImplementation();
            collection.ListDemo();
            collection.StackDemo();
            collection.QueueDemo();
            collection.DictionaryDemo();
            collection.SetDemo();
        }
    }
}