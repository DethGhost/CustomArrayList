using System;

namespace CustomArrayList
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            MyArrayList arrayList = new MyArrayList(new Object[]{10, 20, "string"});
            
            arrayList.Add("New Object");
            Console.WriteLine(arrayList[3]);
            foreach (var VARIABLE in arrayList)
            {
                Console.WriteLine(VARIABLE);
            }
            
            arrayList.Remove(1);
            foreach (var VARIABLE in arrayList)
            {
                Console.WriteLine(VARIABLE);
            }

            Console.WriteLine(arrayList.Length);
            arrayList.Insert(2, "New Value in 3rd position");
            foreach (var VARIABLE in arrayList)
            {
                Console.WriteLine(VARIABLE);
            }
            Console.ReadLine();
        }
    }
}