using System;
using System.Collections;
using System.Collections.Generic;

namespace OOps_learnng
{
   class Students_details()
    {
        //public static void Main(String [] args) 
        {/*
            ArrayList arrayList1 = new ArrayList();
            // Creation
            arrayList1.Add(101);//Adding Integer Value
            arrayList1.Add("James"); //Adding String Value
            arrayList1.Add(23.56);
                // Retrival
           *//* foreach (var item in arrayList1)
            {
                Console.WriteLine(item);
            }*//*
            // indexer
            Console.WriteLine(arrayList1[2]);
            //Update 
            arrayList1[0] = 1;
            Console.WriteLine(arrayList1[0]);
            // deletion
          arrayList1.Remove('2');
            Console.WriteLine(arrayList1[2]);
            foreach (var item in arrayList1)
            {
                Console.WriteLine(item);
            }*/
         // creating hashtable
           //Hashtable hash=new Hashtable();
           // hash.Add(0, "sunday");
           // hash.Add(1, "monday");
           // hash.Add(2, "tuesday");
           // hash.Add(4, "wednesday");
           // hash.Add(5, "thrusday");
           // hash.Add(6, "friday");
           // hash.Add(7, "saturday");
           // // retrive
           
           // foreach (var DAYS in hash)
           // {
           //     Console.WriteLine(DAYS);
           // }
           // //// delete a day
           // hash.Remove(5);
           // foreach (var DAYS in hash.Keys)
           // {
           //     Console.WriteLine(DAYS);
           // }
           // //// update
           // hash[0] = "Monday";
           // Console.WriteLine(hash[0]);
           // foreach (var DAYS in hash.Values) 
           // {
           //     Console.WriteLine(DAYS);
           // }

            // create a dictionary
            /* Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
             keyValuePairs.Add(0, "sunday");
             keyValuePairs.Add(1, "monday");
             keyValuePairs.Add(2, "Tuesday");
             keyValuePairs.Add(4, "Wednesday");
             keyValuePairs.Add(5, "Thrusday");
             keyValuePairs.Add(6, "Friday");
             keyValuePairs.Add(7, "Saturday");

            keyValuePairs.TryAdd(8, "suryodai");
             foreach (var keyValue in keyValuePairs)
             {
                 Console.WriteLine(keyValue);
             }*/


            LinkedList<string> ints = new LinkedList<string>();

            ints.AddFirst("First");

            ints.AddLast("Second");

            ints.AddLast("Third");

            ints.AddFirst("Second First");

            ints.AddFirst("Third First");

            ints.AddLast("Fourth");

            ints.AddLast("Fifth");

            //LinkedListNode<string> node = ints.Find("Fourth");


            LinkedListNode<string> node = ints.Find("Fourth");
            ints.AddBefore(node, "Cheese");



            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }


            //foreach (var item in ints)
            //{
            //    Console.WriteLine(item);
            //}

     //   }
    }
}